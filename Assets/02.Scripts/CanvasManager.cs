using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    // 싱글톤 패턴을 사용하기 위한 인스턴스 변수
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
