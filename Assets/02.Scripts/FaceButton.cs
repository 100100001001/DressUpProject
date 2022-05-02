using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class FaceButton : MonoBehaviour
{
    public CharacterType characterType;

    public Color selectColor = Color.white;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        //Debug.Log("OnClick()");

        switch (characterType)
        {
            case CharacterType.HAIR:
                Character.instance.gameObject.transform.GetChild((int)CharacterType.HAIR).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;

                for (int i = 0; i < 5; i++)
                {
                    if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
                    {
                        selectColor.a = 0.5f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = selectColor;
                    }
                    else
                    {
                        selectColor.a = 1.0f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = selectColor;
                    }
                }

                break;
            case CharacterType.EYE:
                Character.instance.gameObject.transform.GetChild((int)CharacterType.EYE).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;

                for (int i = 5; i < 10; i++)
                {
                    if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == transform.GetChild(0).gameObject.GetComponent<Image>().sprite)
                    {
                        selectColor.a = 0.5f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = selectColor;
                    }
                    else
                    {
                        selectColor.a = 1.0f;

                        CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = selectColor;
                    }
                }

                break;
        }

    }

    public void SetAlpha(bool active)
    {
        if (active)
        {
            selectColor.a = 0.5f;
            gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = selectColor;
            //gameObject.GetComponent<SpriteRenderer>().color = selectColor;
        }
        else
        {
            selectColor.a = 1.0f;
            gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = selectColor;
            //gameObject.GetComponent<SpriteRenderer>().color = selectColor;
        }
    }







}
