using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StageChoiceResolution : MonoBehaviour
{
    public RectTransform contentRect;
    //1334/1920=0.69
    public float contentRectNumberUnder1400 = 0.6f;
    public float contentRectNumberUnder1000 = 0.4f;
    //public float smallSellSize;
    // Start is called before the first frame update
    void Start()
    {
        if(Screen.width < 1000)
        {
            contentRect.localScale = new Vector3(contentRectNumberUnder1000,contentRectNumberUnder1000,1);
            contentRect.localPosition = new Vector3(contentRect.localPosition.x * contentRectNumberUnder1000, contentRect.position.y * contentRectNumberUnder1000, 1);
        }
        else if(Screen.width < 1200)
        {
            contentRect.localScale = new Vector3(contentRectNumberUnder1000+0.1f,contentRectNumberUnder1000+0.1f,1);
            contentRect.localPosition = new Vector3(contentRect.localPosition.x * (contentRectNumberUnder1000+0.1f), contentRect.position.y * (contentRectNumberUnder1000+0.1f), 1);
        }
        else if(Screen.width < 1400)
        {
            // GridLayoutGroup grid = GetComponent<GridLayoutGroup> ();
            // grid.cellSize = new Vector2 (smallSellSize, smallSellSize);
            // Vector2 sd = content.sizeDelta;
            // Debug.Log(sd);
            // sd = sd / 2;
            // content.sizeDelta = sd;
            contentRect.localScale = new Vector3(contentRectNumberUnder1400,contentRectNumberUnder1400,1);
            contentRect.localPosition = new Vector3(contentRect.localPosition.x * contentRectNumberUnder1400, contentRect.position.y * contentRectNumberUnder1400, 1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
