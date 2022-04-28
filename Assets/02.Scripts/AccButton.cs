using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AccButton : MonoBehaviour
{
    public CharacterType characterType;

    public Color color = Color.white;

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

                for (int i = 0; i < 8; i++)
                {
                    if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
                    {
                        color.a = 0.5f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                    else
                    {
                        color.a = 1.0f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                }

                SetAcc(CharacterType.HAT);

                break;
            case CharacterType.GLASSES:

                for (int i = 8; i < 9; i++)
                {
                    if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
                    {
                        color.a = 0.5f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                    else
                    {
                        color.a = 1.0f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                }

                SetAcc(CharacterType.GLASSES);

                break;
            case CharacterType.EARRING:

                for (int i = 9; i < 11; i++)
                {
                    if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
                    {
                        color.a = 0.5f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                    else
                    {
                        color.a = 1.0f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                }

                SetAcc(CharacterType.EARRING);

                break;
            case CharacterType.NECKLACE:

                for (int i = 11; i < 13; i++)
                {
                    if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
                    {
                        color.a = 0.5f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                    else
                    {
                        color.a = 1.0f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                }

                SetAcc(CharacterType.NECKLACE);

                break;
            case CharacterType.SHOES:

                for (int i = 13; i < 24; i++)
                {
                    if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
                    {
                        color.a = 0.5f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                    else
                    {
                        color.a = 1.0f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                }

                SetAcc(CharacterType.SHOES);

                break;
            case CharacterType.SOCKS:

                for (int i = 24; i < 28; i++)
                {
                    if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
                    {
                        color.a = 0.5f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                    else
                    {
                        color.a = 1.0f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                    }
                }

                SetAcc(CharacterType.SOCKS);

                break;
        }
    }

    private void SetAcc(CharacterType characterType)
    {
        //
        if (Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite == null)
        {
            //Debug.Log("a");
            Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;
        }
        else
        {
            if (Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
            {
                //Debug.Log("C");
                Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite = null;

                color.a = 1.0f;
                transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
                return;
            }

            //Debug.Log("B");
            Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;

        }

    }
}
