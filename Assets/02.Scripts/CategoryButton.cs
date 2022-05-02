using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CategoryType
{
    FACE,
    TOP,
    BOTTOM,
    ONEPIECE,
    ACC
}

public class CategoryButton : MonoBehaviour
{
    public CategoryType categoryType;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        //Debug.Log("OnClick()");

        switch (categoryType)
        {
            case CategoryType.FACE:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.SetActive(true);

                //GetItemSetAlpha(CategoryType.FACE, CharacterType.HAIR);
                //GetItemSetAlpha(CategoryType.FACE, CharacterType.EYE);

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

                break;

            //
            //
            //

            case CategoryType.TOP:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.TOP).gameObject.SetActive(true);

                GetItemSetAlpha(CategoryType.TOP, CharacterType.TOP);
                break;

            case CategoryType.BOTTOM:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.BOTTOM).gameObject.SetActive(true);

                GetItemSetAlpha(CategoryType.BOTTOM, CharacterType.BOTTOM);
                break;

            case CategoryType.ONEPIECE:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ONEPIECE).gameObject.SetActive(true);

                GetItemSetAlpha(CategoryType.ONEPIECE, CharacterType.ONEPIECE);
                break;

            //
            //
            //

            case CategoryType.ACC:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.ACC).gameObject.SetActive(true);

                //GetItemSetAlpha(CategoryType.ACC, CharacterType.HAT);
                //GetItemSetAlpha(CategoryType.ACC, CharacterType.GLASSES);
                //GetItemSetAlpha(CategoryType.ACC, CharacterType.EARRING);
                //GetItemSetAlpha(CategoryType.ACC, CharacterType.NECKLACE);
                //GetItemSetAlpha(CategoryType.ACC, CharacterType.SHOES);
                //GetItemSetAlpha(CategoryType.ACC, CharacterType.SOCKS);

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








                break;
        }
    }

    // 알파 값 조절해서 입은 옷 표시
    public void GetItemSetAlpha(CategoryType categoryType, CharacterType characterType)
    {


        switch (categoryType)
        {
            //case CategoryType.FACE:
            //    break;

            //
            //
            //

            case CategoryType.TOP:
            case CategoryType.BOTTOM:
            case CategoryType.ONEPIECE:

                foreach (Transform child in CanvasManager.instance.gameObject.transform.GetChild((int)categoryType).gameObject.transform)
                {
                    //Debug.Log(child.name);

                    if (Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite != child.gameObject.GetComponent<SpriteRenderer>().sprite)
                    {
                        child.gameObject.GetComponent<DragItem>().SetAlpha(false);
                    }
                    else
                    {
                        child.gameObject.GetComponent<DragItem>().SetAlpha(true);
                    }
                }

                break;

                //
                //
                //

                //case CategoryType.ACC:
                //    break;

        }












    }

}
