using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewPortFixer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log(Camera.main.WorldToViewportPoint(transform.position).x);
        transform.position = Camera.main.ViewportToWorldPoint(new Vector3(-0.03f, 0.5f, 0.0f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
