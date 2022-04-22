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

        Debug.Log("OnDrag()");

        Vector3 pickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pickPosition.z = 0;
        gameObject.transform.GetChild(0).transform.position = pickPosition;
    }


    public void OnPointerUp(PointerEventData eventData)
    {
        //Debug.Log("OnPointerUp()");

        if (Vector3.Distance(Character.instance.transform.position, gameObject.transform.GetChild(0).transform.position) <= autoDistance)
        {

            if (Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite == null)
            {
                Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
            }
            else
            {
                //CanvasManager.instance

                Sprite S = Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite;

                Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;

                //for (int i = 0; i < CanvasManager.instance.gameObject.transform.GetChild(1).childCount; i++)
                //{
                //    Debug.Log(i);
                //    CanvasManager.instance.gameObject.transform.GetChild(1).gameObject.transform.GetChild(i).GetComponent<DragItem>().SetAlpha(true);
                //}

                //



                foreach (Transform child in CanvasManager.instance.gameObject.transform.GetChild(1).gameObject.transform)
                {
                    //Debug.Log(child.name);

                    //if (gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite != child.gameObject.GetComponent<SpriteRenderer>().sprite)
                    if (S == child.gameObject.GetComponent<SpriteRenderer>().sprite)
                    {
                        child.gameObject.GetComponent<DragItem>().SetAlpha(false);
                    }
                    //else
                    //{
                    //    child.gameObject.GetComponent<DragItem>().SetAlpha(true);
                    //}
                }



            }

            if (gameObject.transform.GetChild(0).gameObject != null)
            {
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }

        }
        else
        {
            // 지금 선택한 옷과 캐릭터가 입고 있는 옷이 같지 않을 때
            if (gameObject.transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().sprite != Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite)
            {
                foreach (Transform child in CanvasManager.instance.gameObject.transform.GetChild(1).gameObject.transform)
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

            if (gameObject.transform.GetChild(0).gameObject != null)
            {
                Destroy(gameObject.transform.GetChild(0).gameObject);
            }


        }

        GameManager.instance.IsPick = false;


    }

    //public void Pick(bool active)
    //{
    //    isPick = active;
    //    GetComponent<BoxCollider2D>().enabled = active;
    //}

}
