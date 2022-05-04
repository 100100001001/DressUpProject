using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMainBackground : MonoBehaviour
{
    // 배경을 배열로 받음
    public Sprite[] bgArray;
    //public SpriteRenderer bg;

    void Start()
    {
        // 받은 배경의 갯수 안에서 랜덤으로 숫자를 받아서 배경을 Sprite에 할당
        GetComponent<SpriteRenderer>().sprite = bgArray[Random.Range(0, bgArray.Length)];
    }



    //void Update()
    //{
        
    //}



}
