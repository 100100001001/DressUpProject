using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //public GameObject hair;
    //public GameObject eye;

    //public Sprite a;
    //public Sprite b;
    //public Sprite c;
    //public Sprite d;

    public static GameManager instance;

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

    //void Update()
    //{

    //}


    //public void A()
    //{
    //    hair.GetComponent<SpriteRenderer>().sprite = a;
    //}

    //public void B()
    //{
    //    hair.GetComponent<SpriteRenderer>().sprite = b;
    //}

    //public void C()
    //{
    //    eye.GetComponent<SpriteRenderer>().sprite = c;
    //}

    //public void D()
    //{
    //    eye.GetComponent<SpriteRenderer>().sprite = d;
    //}


}
