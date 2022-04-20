using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{

    public static CanvasManager instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }

    }

    public void AllSetActive(bool active)
    {
        for (int i = 0; i < transform.childCount - 1; i++)
        {
            gameObject.transform.GetChild(i).gameObject.SetActive(active);
        }
    }

}
