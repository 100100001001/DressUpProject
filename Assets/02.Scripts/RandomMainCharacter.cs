using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMainCharacter : MonoBehaviour
{
    // 캐릭터를 배열로 받아줌
    public Sprite[] characterArray;
    //public SpriteRenderer bg;

    void Start()
    {
        // 받은 캐릭터의 갯수에서 랜덤으로 숫자를 받아서 Sprite에 할당
        GetComponent<SpriteRenderer>().sprite = characterArray[Random.Range(0, characterArray.Length)];
    }



    //void Update()
    //{

    //}
}
