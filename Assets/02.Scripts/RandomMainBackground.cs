using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMainBackground : MonoBehaviour
{
    // ����� �迭�� ����
    public Sprite[] bgArray;
    //public SpriteRenderer bg;

    void Start()
    {
        // ���� ����� ���� �ȿ��� �������� ���ڸ� �޾Ƽ� ����� Sprite�� �Ҵ�
        GetComponent<SpriteRenderer>().sprite = bgArray[Random.Range(0, bgArray.Length)];
    }



    //void Update()
    //{
        
    //}



}
