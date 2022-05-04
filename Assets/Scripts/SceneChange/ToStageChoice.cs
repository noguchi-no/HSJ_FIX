using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class ToStageChoice : MonoBehaviour
{
    public Image leftBackGround;
    public Image rightBackGround;
    public Text titleText1;
    public Text titleText2;
    public Text titleText3;
    public Text BulletPointTitleText;

    public float moveLength;
    public float duration;
    public Ease easeType;
    public Vector2 jumpDestination = new Vector2();
    public float jumpDuration;
    public float jumpPower;

    Tween a;
    public RectTransform panelRectTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        if(Screen.width > 2100)
        {
            jumpDestination = new Vector2(1600,160);
        }
        if(Screen.width < 1400)
        {
            jumpDestination = new Vector2(900,100);
        }
        //a = this.gameObject.GetComponent<Image>().DOFade(0.0f, duration).SetEase(Ease.InCubic).SetLoops(-1, LoopType.Yoyo);
    }

    public void OnClick (){
        //a.Kill();
        var sequence = DOTween.Sequence();
        sequence.Append(leftBackGround.rectTransform.DOLocalMoveX(-moveLength, duration));
        sequence.Join(rightBackGround.rectTransform.DOLocalMoveX(moveLength, duration));
        sequence.Join(this.gameObject.GetComponent<Image>().DOFade(1f,0f));
        sequence.Join(titleText1.DOFade(0f,duration));
        sequence.Join(titleText2.DOFade(0f, duration));
        sequence.Join(titleText3.DOFade(0f, duration));
        sequence.Join(BulletPointTitleText.DOFade(0f, duration));
        sequence.Join(this.gameObject.transform.DOLocalJump(jumpDestination, jumpPower, 3, jumpDuration).SetEase(Ease.Linear));
        //sequence.AppendInterval(1f);
        sequence.OnComplete(() =>
        {
            SceneManager.LoadScene("StageChoice");
        });
        //sequence.Append(panelRectTransform.DOLocalMoveX(0f, 1f).SetEase(easeType));
        
        // .OnComplete(() =>
        // {

        // });
         //sequence.AppendInterval(1f);
         //titleText.rectTransform.DOMoveY(1200f, duration);

         //leftBackGround.rectTransform.DOLocalMoveX(-1 * moveLength, duration).SetEase(easeType);
         //rightBackGround.rectTransform.DOLocalMoveX(moveLength, duration).SetEase(easeType);
         //FadeManager.Instance.LoadScene ("StageChoice", 0.3f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
