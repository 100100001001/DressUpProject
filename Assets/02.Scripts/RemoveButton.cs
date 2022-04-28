using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoveButton : MonoBehaviour
{
    CharacterType characterType;

    void Start()
    {
        GetComponent<Button>().onClick.AddListener(OnClick);
    }

    public void OnClick()
    {
        Character.instance.gameObject.transform.GetChild((int)CharacterType.HAIR).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(0).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.EYE).GetComponent<SpriteRenderer>().sprite = CanvasManager.instance.gameObject.transform.GetChild((int)CategoryType.FACE).gameObject.transform.GetChild(5).gameObject.transform.GetChild(0).GetComponent<Image>().sprite;

        Character.instance.gameObject.transform.GetChild((int)CharacterType.TOP).GetComponent<SpriteRenderer>().sprite = null;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.BOTTOM).GetComponent<SpriteRenderer>().sprite = null;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite = null;

        Character.instance.gameObject.transform.GetChild((int)CharacterType.HAT).GetComponent<SpriteRenderer>().sprite = null;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.GLASSES).GetComponent<SpriteRenderer>().sprite = null;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.EARRING).GetComponent<SpriteRenderer>().sprite = null;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.NECKLACE).GetComponent<SpriteRenderer>().sprite = null;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.SHOES).GetComponent<SpriteRenderer>().sprite = null;
        Character.instance.gameObject.transform.GetChild((int)CharacterType.SOCKS).GetComponent<SpriteRenderer>().sprite = null;

    }

}