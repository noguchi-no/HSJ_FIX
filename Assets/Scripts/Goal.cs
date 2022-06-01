using System.Collections;
using System.Collections.Generic;
using Systems.Audio;
using UnityEngine;
using DG.Tweening;
using AudioType = Systems.Audio.AudioType;

public class Goal : MonoBehaviour
{
    SystemAudioManager Se;//SE��炷���߂̃X�N���v�g
    StageManager StageManager;
    private GameObject GoalCircle;
    private GameObject PlayerObj;
    private GameObject physicsObject;
    [SerializeField]
    private bool mini;
    
    private void Start()
    {
        GoalCircle = GameObject.Find("GoalCircle");
        GoalCircle.transform.DORotate(new Vector3(0, 0, -360), 2f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);
        GoalCircle.transform.DOScale(new Vector3(0.35f, 0.35f, 0.35f), 1.2f).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
        Se = FindObjectOfType<SystemAudioManager>();
        StageManager = FindObjectOfType<StageManager>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerObj = other.gameObject;
            PlayerObj.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            PlayerObj.GetComponent<Rigidbody2D>().simulated = false;
            PlayerObj.GetComponent<CircleCollider2D>().enabled = false;

            var physicsObj =  GameObject.FindObjectOfType<Player_Physics>();
            physicsObject = physicsObj.gameObject;
            if (physicsObj != null && physicsObj.TryGetComponent(out Player_Physics Physics))
            {
                Debug.Log("physicsObj:"+physicsObj);
                Physics.isCheck = false;
            }

            StartCoroutine(Goalanimation(PlayerObj));
        }
    }

    private void PlayBoundSe(AudioType type)
    {
        if (Se != null) Se.ShotSe(type);
    }

    private IEnumerator Goalanimation(GameObject targetPbPnject)
    {
        var dis = Vector3.Distance(targetPbPnject.transform.position, transform.position);
        var PlayerPos = (targetPbPnject.transform.position - transform.position).normalized;
        if(mini)
        {
            targetPbPnject.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            targetPbPnject.transform.DOScale(new Vector3(0.1f, 0.1f, 0.1f), 2f);
        }
        else
        {
            targetPbPnject.transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
            targetPbPnject.transform.DOScale(new Vector3(0.15f, 0.15f, 0.15f), 2f);
        }
        targetPbPnject.transform.DOScale(new Vector3(0.15f, 0.15f, 0.15f), 2f);
        for (int i = 0; i < 90; i++)
        {
            float temp = 1f * i * 4 / 360;
            //PlayerObj.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f) * (1f - 1f* i / 90);
            var GoalPlayerPos = new Vector3(PlayerPos.x * dis * (1f - temp) * Mathf.Sin(temp * 15), PlayerPos.x * dis * (1f - temp) * Mathf.Cos(temp * 15), 0) + transform.position;
            targetPbPnject.transform.position = GoalPlayerPos;
            yield return new WaitForFixedUpdate();
        }
        var color = targetPbPnject.GetComponent<SpriteRenderer>();
        color.color = new Color(0, 0, 0, 0);
        Destroy(this.gameObject);
        StageManager.stageClear();
        
        var colorS = physicsObject.GetComponent<SpriteRenderer>();
        colorS.color = new Color(0, 0, 0, 0);

        if (StageManager.useHint)
        {
            PlayBoundSe(AudioType.WGoal);
            StageManager.useHint = false;
        }

    }

}
