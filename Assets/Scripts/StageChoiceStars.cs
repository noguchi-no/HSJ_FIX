using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageChoiceStars : MonoBehaviour
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
    private Stage StageNum;
    [SerializeField]
    private GameObject Gold;
    [SerializeField]
    private GameObject Silver;
    [SerializeField]
    private void Start()
    {
        var stageInt = PlayerPrefs.GetInt(StageNum.ToString(), 0);
        Debug.Log(StageNum.ToString() + "F" + stageInt);
        if(stageInt == 1)
        {
            Silver.SetActive(true);
        }
        else if(stageInt == 2)
        {
            Gold.SetActive(true);
        }
    }

}
