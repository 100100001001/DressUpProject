using UnityEngine;
using UnityEngine.EventSystems;

public class DragItem : MonoBehaviour
{
    //public Vector3 startPosition = Vector3.zero;
    public Vector3 startPosition;

    //[SerializeField]
    //public Vector3 pointA = Vector3.zero;
    //public Vector3 pointB = Vector3.zero;
    //public Vector3 offset = Vector3.zero;

    [SerializeField]
    private float autoDistance = 1.0f;

    Color selectColor = Color.white;

    public GameObject prefab;

    private GameObject copyGameObject;

    //private void Start()
    //{
    //    startPosition = transform.position;
    //}

    //private void OnEnable()
    //{
    //    startPosition = transform.position;

    //    transform.position = startPosition;
    //}

    private void OnMouseDown()
    {
        //Debug.Log("OnMouseDown()");

        //    pointA = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    pointA.z = 0;


        if (GameManager.instance.IsPick == false)
        {

            //if (gameObject.GetComponent<SpriteRenderer>().sprite == )
            if (gameObject.GetComponent<SpriteRenderer>().color.a == 1.0f)
            {
                SetAlpha(true);

                GameObject copyGameObject = Instantiate(prefab, transform.position, Quaternion.identity, GameManager.instance.gameObject.transform);
                copyGameObject.GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;
                copyGameObject.AddComponent<PolygonCollider2D>();

                //GameManager.instance.isPick = true;
                GameManager.instance.IsPick = true;

            }

        }

    }

    public void SetAlpha(bool active)
    {
        if (active)
        {
            selectColor.a = 0.5f;
            gameObject.GetComponent<SpriteRenderer>().color = selectColor;
        }
        else
        {
            selectColor.a = 1.0f;
            gameObject.GetComponent<SpriteRenderer>().color = selectColor;
        }
    }

    #region MyRegion
    //private void OnMouseDrag()
    //{
    //    ////Debug.Log("OnMouseDrag()");


    //    //Vector3 pickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    //transform.position = new Vector3(pickPosition.x, pickPosition.y, 0);

    //    ////Vector3 mousePosition = new Vector3(pickPosition.x, pickPosition.y, 0);
    //    ////transform.position = mousePosition;

    //    ////transform.position = new Vector3(pickPosition.x, pickPosition.y, pickPosition.y);




    //    ////    pointB = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    ////    pointB.z = 0;
    //    ////    offset = pointB - pointA;
    //    ////    //transform.position += offset;
    //    ////    transform.Translate(offset);
    //    ////    pointA = pointB;







    //    ////Debug.Log("OnMouseDrag()");


    //    ////pointB = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    ////pointB.z = 0;

    //    ////offset = pointB - pointA;
    //    ////transform.position += offset;
    //    ////transform.Translate(offset);


    //    ////Vector3 pickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //    ////pickPosition.z = 0;
    //    ////transform.position = pickPosition + pointA;
    //    ////transform.Translate(pointA);


    //    ////pointA = pointB;

    //    ////transform.position = new Vector3(pickPosition.x, pickPosition.y, 0);
    //    ////Vector3 mousePosition = new Vector3(pickPosition.x, pickPosition.y, 0);
    //    ////transform.position = mousePosition;
    //    ////transform.position = new Vector3(pickPosition.x, pickPosition.y, pickPosition.y);












    //}

    //private void OnMouseUp()
    //{
    //    //Debug.Log("OnMouseUp()");

    //    //if (Vector3.Distance(Character.instance.transform.position, transform.position) <= autoDistance)
    //    //{
    //    //    Character.instance.gameObject.transform.GetChild((int)CharacterType.ONEPIECE).GetComponent<SpriteRenderer>().sprite = gameObject.GetComponent<SpriteRenderer>().sprite;

    //    //    gameObject.transform.position = startPosition;




    //    //    selectColor.a = 0.5f;
    //    //    gameObject.GetComponent<SpriteRenderer>().color = selectColor;

    //    //}

    //    //pointA = Vector3.zero;
    //    //pointB = Vector3.zero;
    //    //offset = Vector3.zero;

    //}
    #endregion

}




