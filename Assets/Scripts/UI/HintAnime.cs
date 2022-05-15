using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HintAnime : MonoBehaviour
{
    [SerializeField]
    private GameObject[] circles;

    public bool isAnime = false;
    void Start()
    {
        for (int i = 1; i <= 6; i++)
        {
            circles[i].SetActive(false);
        }
        StartCoroutine(anime4()); 
    }

  
    IEnumerator anime4()
    {
        
        while (true)
        {
            if (isAnime)
            {
                for (int i = 1; i <= 6; i++)
                {
                    circles[i].SetActive(false);
                }
                for (int i = 1; i <= 6; i++)
                {
                    circles[i].SetActive(true);
                    circles[i].transform.DOScale(Vector3.zero, 0.6f).From();
                    yield return new WaitForSeconds(0.1f);
                }
                yield return new WaitForSeconds(1.0f);
            }
            yield return new WaitForSeconds(0.2f);
        }
    }
   

    public void setAcive(bool b)
    {
        isAnime = b;
        if (!b)
        {
            for (int i = 1; i <= 6; i++)
            {
                circles[i].SetActive(false);
            }
        }
    }
}
