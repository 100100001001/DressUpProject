using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//public enum ItemType
//{
//    ONEPIECE
//}

public enum CategoryType
{
    HAIR,
    EYE,
    ONEPIECE
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
            case CategoryType.HAIR:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild((int)CharacterType.HAIR).gameObject.SetActive(true);
                break;
            case CategoryType.EYE:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild((int)CharacterType.EYE).gameObject.SetActive(true);
                break;
            case CategoryType.ONEPIECE:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild(2).gameObject.SetActive(true);



                break;
        }
    }



}
