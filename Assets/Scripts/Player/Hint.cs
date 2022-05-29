using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Hint : MonoBehaviour
{
    StageManager manager;
    Player_Physics Player;
    HintAnime anime;
    [SerializeField]
    private int dgree;
    void Awake()
    {
        manager = FindObjectOfType<StageManager>().GetComponent<StageManager>();
        Player = GetComponentInParent<Player_Physics>();
        anime = GetComponent<HintAnime>();
        anime.setAcive(false);

    }

    private void FixedUpdate()
    {
        if(!Player.isSet)
        {
            anime.setAcive(false);
        }
        //gameObject.transform.rotation = Quaternion.Euler(0, 0, dgree);
    }

    public void onHint()
    {
        switch (manager.nowStage)
        {
            case StageManager.Stage.stage1:
                gameObject.transform.rotation = Quaternion.Euler(0,0,-123);
                break;
            case StageManager.Stage.stage2:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 200);
                break;
            case StageManager.Stage.stage3:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, -105);
                break;
            case StageManager.Stage.stage4:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case StageManager.Stage.stage5:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 250);
                break;
            case StageManager.Stage.stage6:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 295);
                break;
            case StageManager.Stage.stage7:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 260);
                break;
            case StageManager.Stage.stage8:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 225);
                break;
            case StageManager.Stage.stage9:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 260);
                break;
            case StageManager.Stage.stage10:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 224);
                break;
            case StageManager.Stage.stage11:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 220);
                break;
            case StageManager.Stage.stage12:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 210);
                break;
            case StageManager.Stage.stage13:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 250);
                break;
            case StageManager.Stage.stage14:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 30);
                break;
            case StageManager.Stage.stage15:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 210);
                break;
            case StageManager.Stage.stage16:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 10);
                break;
            case StageManager.Stage.stage17:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 270);
                break;
            case StageManager.Stage.stage18:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 260);
                break;
            case StageManager.Stage.stage19:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 190);
                break;
            case StageManager.Stage.stage20:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 95);
                break;
            case StageManager.Stage.stage21:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 350);
                break;
            case StageManager.Stage.stage22:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 239);
                break;
            case StageManager.Stage.stage23:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 190);
                break;
            case StageManager.Stage.stage24:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 245);
                break;
            case StageManager.Stage.stage25:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 264);
                break;
            case StageManager.Stage.stage26:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180.0f + 71.253f);
                break;
            case StageManager.Stage.stage27:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 235);
                break;
            case StageManager.Stage.stage28:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 220);
                break;
            case StageManager.Stage.stage29:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180);
                break;
            case StageManager.Stage.stage30:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 180.0f + 77.869f);
                break;
            case StageManager.Stage.stage31:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 250);
                break;
            case StageManager.Stage.stage32:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 260);
                break;
            case StageManager.Stage.stage33:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 190);
                break;
            case StageManager.Stage.stage34:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 82.449f + 180.0f);
                break;
            case StageManager.Stage.stage35:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 283);
                break;
            case StageManager.Stage.stage36:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 170);
                break;
            case StageManager.Stage.stage37:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 205);
                break;
            case StageManager.Stage.stage38:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 110);
                break;
            case StageManager.Stage.stage39:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 30);
                break;
            case StageManager.Stage.stage40:
                gameObject.transform.rotation = Quaternion.Euler(0, 0, 270);
                break;

        }
        Debug.Log("hintanim");
        anime.setAcive(true);
    }
}
