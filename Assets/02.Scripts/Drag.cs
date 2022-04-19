using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour
{

    public Vector3 startPosition = Vector3.zero;

    private void OnMouseDown()
    {
        //Debug.Log("OnMouseDown()");
    }

    private void OnMouseDrag()
    {
        //Debug.Log("OnMouseDrag()");


        Vector3 pickPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pickPosition.x, pickPosition.y, 0);

        //Vector3 mousePosition = new Vector3(pickPosition.x, pickPosition.y, 0);
        //transform.position = mousePosition;

        //transform.position = new Vector3(pickPosition.x, pickPosition.y, pickPosition.y);


    }

    private void OnMouseUp()
    {
        //Debug.Log("OnMouseUp()");

        if (Vector3.Distance(Character.instance.transform.position, transform.position) <= 1.0f)
        {
            gameObject.transform.position = Vector3.zero;
        }

    }

}
