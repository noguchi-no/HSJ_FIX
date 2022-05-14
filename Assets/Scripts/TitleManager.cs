using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class TitleManager : MonoBehaviour
{
    public RectTransform titleTextRectTransform1;
    public RectTransform titleTextRectTransform2;
    public RectTransform titleTextRectTransform3;
    public float duration;
    public Ease easeType;
    public float textHeight;
    public Vector2 jumpDestination = new Vector2();
    public float jumpDuration;
    public float jumpPower;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        
        Sequence sequence = DOTween.Sequence();
        // sequence.Append(titleTextRectTransform1.DOLocalMoveY(textHeight, duration).SetEase(easeType))
        // .Append(titleTextRectTransform2.DOLocalMoveY(textHeight*2, duration).SetEase(easeType))
        // .Append(titleTextRectTransform3.DOLocalMoveY(textHeight*3, duration).SetEase(easeType))
        sequence.Append(titleTextRectTransform1.DOLocalJump(jumpDestination, jumpPower, 1, jumpDuration).SetEase(easeType))
                .Append(titleTextRectTransform2.DOLocalJump(jumpDestination, jumpPower * 1.3f, 1, jumpDuration+0.1f).SetEase(easeType))
                .Append(titleTextRectTransform3.DOLocalJump(jumpDestination, jumpPower*2f, 1, jumpDuration+0.4f).SetEase(easeType))
                .SetLoops(-1);
    }
}
