using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToTitle : MonoBehaviour
{

    public void OnClick ()
    {
        FadeManager.Instance.LoadScene ("StageChoice", 0.3f);
        StageManager.useHint = false;
    }
}
