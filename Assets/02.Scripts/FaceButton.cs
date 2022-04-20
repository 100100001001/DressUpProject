using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum CharacterType
{
    HAIR,
    EYE,
    ONEPIECE
}

public class FaceButton : MonoBehaviour
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
            case CharacterType.HAIR:
                Character.instance.gameObject.transform.GetChild((int)CharacterType.HAIR).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;
                break;
            case CharacterType.EYE:
                Character.instance.gameObject.transform.GetChild((int)CharacterType.EYE).GetComponent<SpriteRenderer>().sprite = transform.GetChild(0).gameObject.GetComponent<Image>().sprite;
                break;
        }
    }

}
