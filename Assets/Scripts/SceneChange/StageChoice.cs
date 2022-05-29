using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class StageChoice : MonoBehaviour
{
    /*クリアしたらそのステージ番号をSetIntする
    PlayerPrefs.SetInt("stageNum", stageNum);
    //PlayerPrefsをセーブする         
    PlayerPrefs.Save();
    */
    private int stageNum;
    public Button[] stageButtons;
    public RectTransform panelRectTransform;
    public Ease easeType;
    //public int stageMaxNum = 50;
    void Start()
    {
        CantTapButton();

        stageNum = PlayerPrefs.GetInt("stageNum", 1);

        panelRectTransform.DOLocalMoveX(0f, 1f).SetEase(easeType);

        for (int i = 0; i < stageNum; i++)
        {
            //半透明にしておいたボタンのアルファを最大まであげる
            //ボタンを押せるようにする
            stageButtons[i].interactable = true;
        }

    }
    private void CantTapButton()
    {
        //全てのボタンは最初は押せないようにする。
        for (int i = 0; i <= stageButtons.Length - 1; i++)
        {
            stageButtons[i].interactable = false;
        }
    }

}
