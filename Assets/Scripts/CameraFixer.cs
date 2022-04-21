using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFixer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(Screen.width > 2000) {
            GetComponent<Camera>().orthographicSize = 7.0f;
        }        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
