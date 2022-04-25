using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackButton : MonoBehaviour
{
    public SpriteRenderer bg;
    public GameObject canvas;
    public GameObject SaveCanvas;
    public Color test;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);

    }

    public void OnClick()
    {
        SaveCanvas.SetActive(false);

        //Debug.Log("OnClick()");
        bg.color = test;

        canvas.SetActive(true);

    }
}

