using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMainCharacter : MonoBehaviour
{
    // ĳ���͸� �迭�� �޾���
    public Sprite[] characterArray;
    //public SpriteRenderer bg;

    void Start()
    {
        // ���� ĳ������ �������� �������� ���ڸ� �޾Ƽ� Sprite�� �Ҵ�
        GetComponent<SpriteRenderer>().sprite = characterArray[Random.Range(0, characterArray.Length)];
    }



    //void Update()
    //{

    //}
}
