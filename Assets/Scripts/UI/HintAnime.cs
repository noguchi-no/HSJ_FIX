using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class HintAnime : MonoBehaviour
{
    [SerializeField]
    private GameObject[] circles;

    private enum Type
    {
        type1,
        type2,
        type3,
        type4,
        type5,
    }

    [SerializeField]
    private Type animeType;
    public bool isAnime = false;
    void Start()
    {
        for (int i = 1; i <= 6; i++)
        {
            circles[i].SetActive(false);
        }
        switch (animeType)
        {
            case Type.type1:
                StartCoroutine(anime1());
                break;
            case Type.type2:
                StartCoroutine(anime2());
                break;
            case Type.type3:
                StartCoroutine(anime3());
                break;
            case Type.type4:
                StartCoroutine(anime4());
                break;
            case Type.type5:
                StartCoroutine(anime5());
                break;
        }
    }

    IEnumerator anime1()
    {
        while (true)
        {
            if (isAnime)
            {
                for (int i = 1; i <= 6; i++)
                {
                    circles[i].SetActive(true);
                    circles[i].transform.DOMove(circles[0].transform.position, 0.6f).From();
                }
            }
            yield return new WaitForSeconds(1.5f);
        }
    }

    IEnumerator anime2()
    {
        while (true)
        {
            if (isAnime)
            {
                for (int i = 1; i <= 6; i++)
                {
                    circles[i].SetActive(true);
                    circles[i].transform.DOScale(Vector3.zero, 0.6f).From();
                }
            }
            yield return new WaitForSeconds(1.5f);
        }
    }
    IEnumerator anime3()
    {
        while (true)
        {
            if (isAnime)
            {
                for (int i = 1; i <= 6; i++)
                {
                    circles[i].SetActive(true);
                    circles[i].transform.DOMove(circles[0].transform.position, 0.6f + i * 0.1f).From();
                }
            }
            yield return new WaitForSeconds(1.5f);
        }
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
            }
            yield return new WaitForSeconds(1.2f);
        }
    }
    IEnumerator anime5()
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
                    circles[i].transform.DOMove(circles[i - 1].transform.position, 0.2f + i * 0.03f).From();
                    circles[i].transform.position = circles[i - 1].transform.position;
                    yield return new WaitForSeconds(0.2f + i * 0.03f);
                }
            }
            yield return new WaitForSeconds(0.8f);
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
