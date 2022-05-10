using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToTitle : MonoBehaviour
{

    public void OnClick ()
    {   
        if(SceneManager.GetActiveScene().name == "StageChoice")
        {
            FadeManager.Instance.LoadScene ("Title", 0.3f);
        }
        else
        {
            FadeManager.Instance.LoadScene ("StageChoice", 0.3f);
            StageManager.useHint = false;
        }
        
    }
}
