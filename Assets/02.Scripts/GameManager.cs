using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{

    public static GameManager instance;

    [SerializeField]
    private bool isPick = false;
    public bool IsPick
    {
        get
        {
            return isPick;
        }
        set
        {
            isPick = value;
            GetComponent<BoxCollider2D>().enabled = isPick;
        }
    }


    public float autoDistance = 1.5f;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            //DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this)
            {
                Destroy(this.gameObject);
            }
        }

        GetComponent<BoxCollider2D>().enabled = false;

    }




    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown()");

    }



    public void OnDrag(PointerEventData eventData)
    {

        if (GameManager.instance.IsPick == false)
        {
            return;
        }

        //Debug.Log("OnDrag()");

        Vector3 pickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pickPosition.z = 0;
        gameObject.transform.GetChild(0).transform.position = pickPosition;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("OnPointerUp()");

        if (Vector3.Distance(Character.instance.transform.position, gameObject.transform.GetChild(0).transform.position) <= autoDistance)
        {

            switch (gameObject.transform.GetChild(0).GetComponent<PickPrefab>().pickType)
            {
                //case CharacterType.HAIR:
                //    break;
                //case CharacterType.EYE:
                //    break;

                case CharacterType.TOP:
                    CompleteDressUp(CharacterType.TOP, CategoryType.TOP);
                    break;
                case CharacterType.BOTTOM:
                    CompleteDressUp(CharacterType.BOTTOM, CategoryType.BOTTOM);
                    break;
                case CharacterType.ONEPIECE:
                    CompleteDressUp(CharacterType.ONEPIECE, CategoryType.ONEPIECE);
                    break;
                    //
                    //
                    //
                case CharacterType.HAT:
                    CompleteDressUp(CharacterType.HAT, CategoryType.ACC);
                    break;
                case CharacterType.GLASSES:
                    CompleteDressUp(CharacterType.GLASSES, CategoryType.ACC);
                    break;
                case CharacterType.EARRING:
                    CompleteDressUp(CharacterType.EARRING, CategoryType.ACC);
                    break;
                case CharacterType.NECKLACE:
                    CompleteDressUp(CharacterType.NECKLACE, CategoryType.ACC);
                    break;
                case CharacterType.SHOES:
                    CompleteDressUp(CharacterType.SHOES, CategoryType.ACC);
                    break;
                case CharacterType.SOCKS:
                    CompleteDressUp(CharacterType.SOCKS, CategoryType.ACC);
                    break;
            }

            CheckItem();

            if (gameObject.transform.GetChild(0).gameObject != null)
            {
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }

        }
        // 옷을 캐릭터 주변(autoDistance)이 아닌 다른 곳에 놓았을 때
        else
        {



            // 위치 초기화, 알파값 원상태로(1.0f)
            switch (gameObject.transform.GetChild(0).GetComponent<PickPrefab>().pickType)
            {
                //case CharacterType.HAIR:
                //    break;
                //case CharacterType.EYE:
                //    break;

                case CharacterType.TOP:
                    Reset(CharacterType.TOP, CategoryType.TOP);
                    break;
                case CharacterType.BOTTOM:
                    Reset(CharacterType.BOTTOM, CategoryType.BOTTOM);
                    break;
                case CharacterType.ONEPIECE:
                    Reset(CharacterType.ONEPIECE, CategoryType.ONEPIECE);
                    break;
                case CharacterType.HAT:
                    break;
                case CharacterType.GLASSES:
                    break;
                case CharacterType.EARRING:
                    break;
                case CharacterType.NECKLACE:
                    break;
                case CharacterType.SHOES:
                    break;
                case CharacterType.SOCKS:
                    break;
            }

            

            

            if (gameObject.transform.GetChild(0).gameObject != null)
            {
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }





        }

        GameManager.instance.IsPick = false;


    }

    private void CompleteDressUp(CharacterType characterType, CategoryType categoryType)
    {


        if (Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite == null)
        {
            Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
        }
        else
        {
            Sprite beforeItemSprite = Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite;

           

            Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;

            //for (int i = 0; i < CanvasManager.instance.gameObject.transform.GetChild(1).childCount; i++)
            //{
            //    Debug.Log(i);
            //    CanvasManager.instance.gameObject.transform.GetChild(1).gameObject.transform.GetChild(i).GetComponent<DragItem>().SetAlpha(true);
            //}

            //



            foreach (Transform child in CanvasManager.instance.gameObject.transform.GetChild((int)categoryType).gameObject.transform)
            {
                //Debug.Log(child.name);

                //if (gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite != child.gameObject.GetComponent<SpriteRenderer>().sprite)
                if (beforeItemSprite == child.gameObject.GetComponent<SpriteRenderer>().sprite)
                {
                    child.gameObject.GetComponent<DragItem>().SetAlpha(false);
                }
                //else
                //{
                //    child.gameObject.GetComponent<DragItem>().SetAlpha(true);
                //}
            }

        }
    }

    private void Reset(CharacterType characterType, CategoryType categoryType)
    {
        if (gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite != Character.instance.gameObject.transform.GetChild((int)characterType).GetComponent<SpriteRenderer>().sprite)
        {
            foreach (Transform child in CanvasManager.instance.gameObject.transform.GetChild((int)categoryType).gameObject.transform)
            {
                //Debug.Log(child.name);

                //if (gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite != child.gameObject.GetComponent<SpriteRenderer>().sprite)
                if (gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite == child.gameObject.GetComponent<SpriteRenderer>().sprite)
                {
                    child.gameObject.GetComponent<DragItem>().SetAlpha(false);
                }
                //else
                //{
                //    child.gameObject.GetComponent<DragItem>().SetAlpha(true);
                //}
            }

        }

    }


    private void CheckItem()
    {

        if (gameObject.transform.GetChild(0).GetComponent<PickPrefab>().pickType == CharacterType.ONEPIECE)
        {
            //Debug.Log("CharacterType.ONEPIECE");
            Character.instance.gameObject.transform.GetChild((int)CharacterType.TOP).GetComponent<SpriteRenderer>().sprite = null;
            Character.instance.gameObject.transform.GetChild((int)CharacterType.BOTTOM).GetComponent<SpriteRenderer>().sprite = null;
        }
        else if (gameObject.transform.GetChild(0).GetComponent<PickPrefab>().pickType == CharacterType.TOP || gameObject.transform.GetChild(0).GetComponent<PickPrefab>().pickType == CharacterType.BOTTOM)
        {
            //Debug.Log("CharacterType.TOP,CharacterType.BOTTOM");
            Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite = null;
        }



    }

    //public void Pick(bool active)
    //{
    //    isPick = active;
    //    GetComponent<BoxCollider2D>().enabled = active;
    //}




}
