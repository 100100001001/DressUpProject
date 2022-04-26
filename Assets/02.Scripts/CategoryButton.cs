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
                break;

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
        }
    }

    public void GetItemSetAlpha(CategoryType categoryType, CharacterType characterType)
    {
        // ���� �� �����ؼ� ���� �� ǥ��
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

    }

}
