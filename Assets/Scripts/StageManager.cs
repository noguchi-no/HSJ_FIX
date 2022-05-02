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
    static public bool useHint = false;
    static int playNum;

    private Tweener fade;

    public CanvasGroup hintButton;

    public AudioClip startSound;
    public AudioClip clearNoHintSound;
    AudioSource audioSource;

    private void Awake()
    {
        StageClearText1 = GameObject.Find("StageClear1");
        StageClearText1.SetActive(false);
        StageClearText2 = GameObject.Find("StageClear2");
        StageClearText2.SetActive(false);

        useHint = false;
    }
    #region
    static bool stage1 = false;
    static bool stage2 = false;
    static bool stage3 = false;
    static bool stage4 = false;
    static bool stage5 = false;
    static bool stage6 = false;
    static bool stage7 = false;
    static bool stage8 = false;
    static bool stage9 = false;
    static bool stage10 = false;
    static bool stage11 = false;
    static bool stage12 = false;
    static bool stage13 = false;
    static bool stage14 = false;
    static bool stage15 = false;
    static bool stage16 = false;
    static bool stage17 = false;
    static bool stage18 = false;
    static bool stage19 = false;
    static bool stage20 = false;
    static bool stage21 = false;
    static bool stage22 = false;
    static bool stage23 = false;
    static bool stage24 = false;
    static bool stage25 = false;
    static bool stage26 = false;
    static bool stage27 = false;
    static bool stage28 = false;
    static bool stage29 = false;
    static bool stage30 = false;
    static bool stage31 = false;
    static bool stage32 = false;
    static bool stage33 = false;
    static bool stage34 = false;
    static bool stage35 = false;
    static bool stage36 = false;
    static bool stage37 = false;
    static bool stage38 = false;
    static bool stage39 = false;
    static bool stage40 = false;
    #endregion
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        playNum++;
        TitleText = GameObject.Find("TitleText").GetComponent<Text>();
        SubTitleText = GameObject.Find("SubTitleText").GetComponent<Text>();
        PlayerCs = FindObjectOfType<Player_Physics>().GetComponent<Player_Physics>();
        Player = GameObject.Find("Player");
        switch (nowStage)
        {
            case Stage.stage1:
                if (stage1) break;
                startAnime();
                stage1 = true;
                break;
            #region
            case Stage.stage2:
                if (stage2) break;
                startAnime();
                stage2 = true;
                break;
            case Stage.stage3:
                if (stage3) break;
                startAnime();
                stage3 = true;
                break;
            case Stage.stage4:
                if (stage4) break;
                startAnime();
                stage4 = true;
                break;
            case Stage.stage5:
                if (stage5) break;
                startAnime();
                stage5 = true;
                break;
            case Stage.stage6:
                if (stage6) break;
                startAnime();
                stage6 = true;
                break;
            case Stage.stage7:
                if (stage7) break;
                startAnime();
                stage7 = true;
                break;
            case Stage.stage8:
                if (stage8) break;
                startAnime();
                stage8 = true;
                break;
            case Stage.stage9:
                if (stage9) break;
                startAnime();
                stage9 = true;
                break;
            case Stage.stage10:
                if (stage10) break;
                startAnime();
                stage10 = true;
                break;
            case Stage.stage11:
                if (stage11) break;
                startAnime();
                stage11 = true;
                break;
            case Stage.stage12:
                if (stage12) break;
                startAnime();
                stage12 = true;
                break;
            case Stage.stage13:
                if (stage13) break;
                startAnime();
                stage13 = true;
                break;
            case Stage.stage14:
                if (stage14) break;
                startAnime();
                stage14 = true;
                break;
            case Stage.stage15:
                if (stage15) break;
                startAnime();
                stage15 = true;
                break;
            case Stage.stage16:
                if (stage16) break;
                startAnime();
                stage16 = true;
                break;
            case Stage.stage17:
                if (stage17) break;
                startAnime();
                stage17 = true;
                break;
            case Stage.stage18:
                if (stage18) break;
                startAnime();
                stage18 = true;
                break;
            case Stage.stage19:
                if (stage19) break;
                startAnime();
                stage19 = true;
                break;
            case Stage.stage20:
                if (stage20) break;
                startAnime();
                stage20 = true;
                break;
            case Stage.stage21:
                if (stage21) break;
                startAnime();
                stage21 = true;
                break;
            case Stage.stage22:
                if (stage22) break;
                startAnime();
                stage22 = true;
                break;
            case Stage.stage23:
                if (stage23) break;
                startAnime();
                stage23 = true;
                break;
            case Stage.stage24:
                if (stage24) break;
                startAnime();
                stage24 = true;
                break;
            case Stage.stage25:
                if (stage25) break;
                startAnime();
                stage25 = true;
                break;
            case Stage.stage26:
                if (stage26) break;
                startAnime();
                stage26 = true;
                break;
            case Stage.stage27:
                if (stage27) break;
                startAnime();
                stage27 = true;
                break;
            case Stage.stage28:
                if (stage28) break;
                startAnime();
                stage28 = true;
                break;
            case Stage.stage29:
                if (stage29) break;
                startAnime();
                stage29 = true;
                break;
            case Stage.stage30:
                if (stage30) break;
                startAnime();
                stage30 = true;
                break;
            case Stage.stage31:
                if (stage31) break;
                startAnime();
                stage31 = true;
                break;
            case Stage.stage32:
                if (stage32) break;
                startAnime();
                stage32 = true;
                break;
            case Stage.stage33:
                if (stage33) break;
                startAnime();
                stage33 = true;
                break;
            case Stage.stage34:
                if (stage34) break;
                startAnime();
                stage34 = true;
                break;
            case Stage.stage35:
                if (stage35) break;
                startAnime();
                stage35 = true;
                break;
            case Stage.stage36:
                if (stage36) break;
                startAnime();
                stage36 = true;
                break;
            case Stage.stage37:
                if (stage37) break;
                startAnime();
                stage37 = true;
                break;
            case Stage.stage38:
                if (stage38) break;
                startAnime();
                stage38 = true;
                break;
            case Stage.stage39:
                if (stage39) break;
                startAnime();
                stage39 = true;
                break;
            case Stage.stage40:
                if (stage40) break;
                startAnime();
                stage40 = true;
                break;
                #endregion
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

    }

    public void usedHint()
    {
        useHint = true;
    }
    private void startAnime()
    {

        TitleText.DOFade(1.0f, 1.3f).SetEase(Ease.InOutQuint).SetLoops(2, LoopType.Yoyo);
        SubTitleText.DOFade(1.0f, 1.3f).SetEase(Ease.InOutQuint).SetLoops(2, LoopType.Yoyo);
        
        if (PlayerCs != null) PlayerCs.titleCallPowerWait();
        if (WarpGate != null) StartCoroutine(PlayerWarpStart());

        DOVirtual.DelayedCall (1f, ()=> audioSource.PlayOneShot(startSound)); 
    }

    public void stageClear()
    {
        playNum = 0;
        if(useHint) StageClearText2.SetActive(true);
        else if(!useHint) 
        {
            StageClearText1.SetActive(true);
            audioSource.PlayOneShot(clearNoHintSound);
        }
        StartCoroutine(SceneChange());
    }

    IEnumerator SceneChange()
    {
        if(PlayerPrefs.GetInt("stageNum") < nowStageNum)
        {
            PlayerPrefs.SetInt("stageNum", nowStageNum);
            PlayerPrefs.Save();
        }
        yield return new WaitForSeconds(2f);

        FadeManager.Instance.LoadScene(nextScene, 0f);
    }

    IEnumerator PlayerWarpStart()
    {
        WarpGate.SetActive(true);
        var color = Player.GetComponent<SpriteRenderer>();
        color.color = new Color(0, 0, 0, 0);
        yield return new WaitForSeconds(1f);
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
