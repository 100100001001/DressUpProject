using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum FaceType
{
    HAIR,
    EYE
}

public class FaceButton : MonoBehaviour
{
    public FaceType faceType;

    private void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        //Debug.Log("OnClick()");

        switch (faceType)
        {
            case FaceType.HAIR:
                Character.instance.gameObject.transform.GetChild((int)FaceType.HAIR).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;
                break;
            case FaceType.EYE:
                Character.instance.gameObject.transform.GetChild((int)FaceType.EYE).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;
                break;
        }
    }

}
