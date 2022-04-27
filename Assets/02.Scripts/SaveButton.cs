using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.IO;

public class SaveButton : MonoBehaviour
{
    public SpriteRenderer bg;
    public GameObject canvas;
    public GameObject SaveCanvas;

    public string m_Path = @"C:\Users\user\Desktop";
    public string m_FilePrefix = "hehe";
    private string m_FilePath;

    public AudioClip audioClip;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);

    }

    public void OnClick()
    {
        SaveCanvas.SetActive(true);

        //Debug.Log("OnClick()");
        Color a = Color.white;
        bg.color = a;

        canvas.SetActive(false);


        Save();

    }

    public void Save()
    {
        //m_FilePath = m_Path + m_FilePrefix + DateTime.Now.ToString("yyyyMMddhhmmss") + ".png";
        //ScreenCapture.CaptureScreenshot(m_FilePath);

        //ScreenCapture.CaptureScreenshot("C:\\Users\\user\\Desktop\\"+ "Screenshot" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".png");

        ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop),
        "Screenshot" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".png"));

        //Application.CaptureScreenshot("Screenshot.png");

        SoundManager.instance.GetComponent<AudioSource>().clip = audioClip;
        SoundManager.instance.GetComponent<AudioSource>().Play();

    }
}
