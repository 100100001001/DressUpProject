using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BackgroundButton : MonoBehaviour
{
    public Sprite[] bgArray;
    public SpriteRenderer bg;
    public int index = 0;
    

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);

    }

    public void OnClick()
    {
        //Debug.Log("OnClick()");
       
        index++;
        if (index > bgArray.Length-1)
        {
            index = 0;
        }

        bg.sprite = bgArray[index];
    }
}
