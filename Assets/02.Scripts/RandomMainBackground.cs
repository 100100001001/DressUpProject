using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMainBackground : MonoBehaviour
{
    public Sprite[] bgArray;
    //public SpriteRenderer bg;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = bgArray[Random.Range(0, bgArray.Length)];
    }



    //void Update()
    //{
        
    //}



}
