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

    FACE,
    //HAIR,
    //EYE,
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
            case CategoryType.FACE:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild(0).gameObject.SetActive(true);
                break;
            case CategoryType.ONEPIECE:
                CanvasManager.instance.AllSetActive(false);
                CanvasManager.instance.gameObject.transform.GetChild(1).gameObject.SetActive(true);
                break;
        }
    }



}
