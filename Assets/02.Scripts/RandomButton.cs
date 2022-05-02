using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// ·£´ý ¿ÊÀÔÈ÷±â ¹öÆ°
public class RandomButton : MonoBehaviour
{
    // ¹è°æ
    public GameObject RandomBG;

    public Color color = Color.white;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        Character.instance.gameObject.transform.GetChild((int)CharacterType.HAIR).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(Random.Range(0, 5)).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.EYE).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(Random.Range(5, 10)).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;

        //int r = ;
        if (Random.Range(0, 2) == 1)
        {
            Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite = null;

            Character.instance.gameObject.transform.GetChild((int)CharacterType.TOP).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.TOP).gameObject.transform.GetChild(Random.Range(0, CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.TOP).transform.childCount)).GetComponent<SpriteRenderer>().sprite;
            Character.instance.gameObject.transform.GetChild((int)CharacterType.BOTTOM).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.BOTTOM).gameObject.transform.GetChild(Random.Range(0, CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.BOTTOM).transform.childCount)).GetComponent<SpriteRenderer>().sprite;
        }
        else
        {

            Character.instance.gameObject.transform.GetChild((int)CharacterType.TOP).GetComponent<SpriteRenderer>().sprite = null;
            Character.instance.gameObject.transform.GetChild((int)CharacterType.BOTTOM).GetComponent<SpriteRenderer>().sprite = null;

            Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ONEPIECE).gameObject.transform.GetChild(Random.Range(0, CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ONEPIECE).transform.childCount)).GetComponent<SpriteRenderer>().sprite;
        }

        //

        Character.instance.gameObject.transform.GetChild((int)CharacterType.HAT).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(Random.Range(0, 8)).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.GLASSES).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(8).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.EARRING).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(Random.Range(9, 11)).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.NECKLACE).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(Random.Range(11, 13)).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.SHOES).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(Random.Range(13, 24)).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.SOCKS).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(Random.Range(24, 28)).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;

        //

        if (Random.Range(0, 2) == 0)
        {
            Character.instance.gameObject.transform.GetChild((int)CharacterType.HAT).GetComponent<SpriteRenderer>().sprite = null;
        }
        if (Random.Range(0, 2) == 0)
        {
            Character.instance.gameObject.transform.GetChild((int)CharacterType.GLASSES).GetComponent<SpriteRenderer>().sprite = null;
        }
        if (Random.Range(0, 2) == 0)
        {
            Character.instance.gameObject.transform.GetChild((int)CharacterType.EARRING).GetComponent<SpriteRenderer>().sprite = null;
        }
        if (Random.Range(0, 2) == 0)
        {
            Character.instance.gameObject.transform.GetChild((int)CharacterType.NECKLACE).GetComponent<SpriteRenderer>().sprite = null;
        }
        if (Random.Range(0, 2) == 0)
        {
            Character.instance.gameObject.transform.GetChild((int)CharacterType.SHOES).GetComponent<SpriteRenderer>().sprite = null;
        }
        if (Random.Range(0, 2) == 0)
        {
            Character.instance.gameObject.transform.GetChild((int)CharacterType.SOCKS).GetComponent<SpriteRenderer>().sprite = null;
        }



        RandomBG.GetComponent<BackgroundButton>().bg.sprite = RandomBG.GetComponent<BackgroundButton>().bgArray[Random.Range(0, RandomBG.GetComponent<BackgroundButton>().bgArray.Length)];

        //

        foreach (Transform child in CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform)
        {
            //Debug.Log(child.name);

            color.a = 1.0f;

            //child.gameObject.GetComponent<DragItem>().SetAlpha(false);

            child.gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().color = color;
        }

        //

        for (int i = 0; i < 5; i++)
        {
            if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == Character.instance.gameObject.transform.GetChild((int)CharacterType.HAIR).GetComponent<SpriteRenderer>().sprite)
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.GetComponent<FaceButton>().SetAlpha(true);
            }
            else
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.GetComponent<FaceButton>().SetAlpha(false);
            }
        }
        for (int i = 5; i < 10; i++)
        {
            if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == Character.instance.gameObject.transform.GetChild((int)CharacterType.EYE).GetComponent<SpriteRenderer>().sprite)
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.GetComponent<FaceButton>().SetAlpha(true);
            }
            else
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(i).gameObject.GetComponent<FaceButton>().SetAlpha(false);
            }
        }


        //

        for (int i = 0; i < 8; i++)
        {
            if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == Character.instance.gameObject.transform.GetChild((int)CharacterType.HAT).GetComponent<SpriteRenderer>().sprite)
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(true);
            }
            else
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(false);
            }
        }
        for (int i = 8; i < 9; i++)
        {
            if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == Character.instance.gameObject.transform.GetChild((int)CharacterType.GLASSES).GetComponent<SpriteRenderer>().sprite)
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(true);
            }
            else
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(false);
            }
        }
        for (int i = 9; i < 11; i++)
        {
            if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == Character.instance.gameObject.transform.GetChild((int)CharacterType.EARRING).GetComponent<SpriteRenderer>().sprite)
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(true);
            }
            else
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(false);
            }
        }
        for (int i = 11; i < 13; i++)
        {
            if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == Character.instance.gameObject.transform.GetChild((int)CharacterType.NECKLACE).GetComponent<SpriteRenderer>().sprite)
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(true);
            }
            else
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(false);
            }
        }
        for (int i = 13; i < 24; i++)
        {
            if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == Character.instance.gameObject.transform.GetChild((int)CharacterType.SHOES).GetComponent<SpriteRenderer>().sprite)
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(true);
            }
            else
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(false);
            }
        }
        for (int i = 24; i < 28; i++)
        {
            if (CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).gameObject.GetComponent<Image>().sprite == Character.instance.gameObject.transform.GetChild((int)CharacterType.SOCKS).GetComponent<SpriteRenderer>().sprite)
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(true);
            }
            else
            {
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.transform.GetChild(i).gameObject.GetComponent<AccButton>().SetAlpha(false);
            }
        }









    }

}
