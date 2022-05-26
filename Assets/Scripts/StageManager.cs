using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class StageManager : MonoBehaviour
{
    #region
    public enum Stage
    {
        stage1,
        stage2,
        stage3,
        stage4,
        stage5,
        stage6,
        stage7,
        stage8,
        stage9,
        stage10,
        stage11,
        stage12,
        stage13,
        stage14,
        stage15,
        stage16,
        stage17,
        stage18,
        stage19,
        stage20,
        stage21,
        stage22,
        stage23,
        stage24,
        stage25,
        stage26,
        stage27,
        stage28,
        stage29,
        stage30,
        stage31,
        stage32,
        stage33,
        stage34,
        stage35,
        stage36,
        stage37,
        stage38,
        stage39,
        stage40,
    }
    #endregion
    [SerializeField]
    public Stage nowStage;
    private Text TitleText;
    private Text SubTitleText;
    private GameObject Player;
    private Player_Physics PlayerCs;
    private GameObject StageClearText1;
    private GameObject StageClearText2;
    [SerializeField]
    private SceneObject nextScene;
    [SerializeField]
    private int nowStageNum;
    [SerializeField]
    private GameObject WarpGate;
    static public bool useHint;
    static int playNum;

    private Tweener fade;

    public CanvasGroup hintButton;
    [SerializeField]
    private GameObject hintObject;

    public AudioClip startSound;
    public AudioClip clearNoHintSound;
    [SerializeField]
    public AudioClip HintSound;
    AudioSource audioSource;
    [SerializeField]
    private bool resetClear = false;

    private GameObject whitePaper;

    private void Awake()
    {
        StageClearText1 = GameObject.Find("StageClear1");
        StageClearText1.SetActive(false);
        StageClearText2 = GameObject.Find("StageClear2");
        StageClearText2.SetActive(false);

    }

    public static bool isStartAnime = false;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playNum++;
        TitleText = GameObject.Find("TitleText").GetComponent<Text>();
        SubTitleText = GameObject.Find("SubTitleText").GetComponent<Text>();
        PlayerCs = FindObjectOfType<Player_Physics>().GetComponent<Player_Physics>();
        Player = GameObject.Find("Player");
        whitePaper = GameObject.FindGameObjectWithTag("white");

        if(!isStartAnime)
        {
            isStartAnime = true;
            startAnime();
        } else {
            whitePaper.SetActive(false);
        }
        var hint = GameObject.Find("HintButton");
        if (playNum > 7)
        {
            hint.SetActive(true);
        }
        else
        {
            hint.SetActive(false);
        }

        fade = hintButton.DOFade(0.0f, 1f).SetEase(Ease.InCubic).SetLoops(-1, LoopType.Yoyo);
        if (useHint) stopFade();

        if(resetClear) PlayerPrefs.SetInt("stageNum", 1);

        if(useHint)
        {

            FindObjectOfType<Hint>().GetComponent<Hint>().onHint();
        }
    }
    private void FixedUpdate()
    {
        if (!PlayerCs.isSet)
        {
            hintObject.gameObject.SetActive(false);
        }
    }

    public void usedHint()
    {
        if (!useHint)
        {
            audioSource.PlayOneShot(HintSound);
            useHint = true;
        }
    }
    private void startAnime()
    {

        TitleText.DOFade(1.0f, 1.3f).SetEase(Ease.InOutQuint).SetLoops(2, LoopType.Yoyo);
        SubTitleText.DOFade(1.0f, 1.3f).SetEase(Ease.InOutQuint).SetLoops(2, LoopType.Yoyo);
        whitePaper.GetComponent<RawImage>().DOFade(0.2f, 1.3f).SetEase(Ease.InOutQuint).SetLoops(2, LoopType.Yoyo);


        if (PlayerCs != null) PlayerCs.titleCallPowerWait();
        if (WarpGate != null) StartCoroutine(PlayerWarpStart());

        DOVirtual.DelayedCall (1f, ()=> audioSource.PlayOneShot(startSound)); 
    }

    public void stageClear()
    {
        playNum = 0;
        if (useHint)
        {
            StageClearText2.SetActive(true);
            PlayerPrefs.SetInt(nowStage.ToString(), 1);
        }
        else if (!useHint)
        {
            PlayerPrefs.SetInt(nowStage.ToString(), 2);
            StageClearText1.SetActive(true);
            audioSource.PlayOneShot(clearNoHintSound);
            useHint = false;
        }
        isStartAnime = false;
        PlayerPrefs.Save();
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        if(PlayerPrefs.GetInt("stageNum") <= nowStageNum)
        {
            PlayerPrefs.SetInt("stageNum", nowStageNum + 1);
            PlayerPrefs.Save();
        }
        yield return new WaitForSeconds(2f);

        FadeManager.Instance.LoadScene(nextScene, 0f);
    }

    IEnumerator PlayerWarpStart()
    {
        var color = Player.GetComponent<SpriteRenderer>();
        color.color = new Color(0, 0, 0, 0);
        yield return new WaitForSeconds(1f);
        WarpGate.SetActive(true);
        WarpGate.transform.position = Player.transform.position;
        WarpGate.transform.DOScale(new Vector3(0.7f, 0.7f, 0.7f), 1.0f);
        WarpGate.transform.DORotate(new Vector3(0f, 0f, -360f), 1.0f, RotateMode.FastBeyond360).SetEase(Ease.Linear);
        yield return new WaitForSeconds(1.0f);
        color.color = new Color(0.2313726f, 0.2313726f, 0.2313726f, 1);
        WarpGate.transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 1.0f);
        WarpGate.transform.DORotate(new Vector3(0f, 0f, -360f), 1.0f, RotateMode.FastBeyond360).SetEase(Ease.Linear);
        yield return new WaitForSeconds(0.9f);
        WarpGate.SetActive(false);
    }

    public void stopFade()
    {
        fade.Kill();
    }

}
