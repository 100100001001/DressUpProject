using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMainCharacter : MonoBehaviour
{
    public Sprite[] characterArray;
    //public SpriteRenderer bg;

    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = characterArray[Random.Range(0, characterArray.Length)];
    }



    //void Update()
    //{

    //}
}
