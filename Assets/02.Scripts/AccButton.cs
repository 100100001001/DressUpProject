using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccButton : MonoBehaviour
{
    public CharacterType characterType;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        //Debug.Log("OnClick()");

        switch (characterType)
        {
            case CharacterType.HAT:
                SetAcc(CharacterType.HAT);
                break;
            case CharacterType.GLASSES:
                SetAcc(CharacterType.GLASSES);
                break;
            case CharacterType.EARRING:
                SetAcc(CharacterType.EARRING);
                break;
            case CharacterType.NECKLACE:
                SetAcc(CharacterType.NECKLACE);
                break;
            case CharacterType.SHOES:
                SetAcc(CharacterType.SHOES);
                break;
            case CharacterType.SOCKS:
                SetAcc(CharacterType.SOCKS);
                break;
        }
    }

    private void SetAcc(CharacterType characterType)
    {
        if (Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite == null)
        {
            Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;
        }
        else
        {
            Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;

            if (Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
            {
                Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite = null;
            }
        }

    }
}
