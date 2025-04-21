using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    public Rigidbody player;

    public bool canDrag;

    public Camera mainCamera;

    
    void Start()
    {

    }


    public void OnPointerDown(PointerEventData eventData)
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            if (hit.collider.CompareTag("Solder"))
            {
                canDrag = true;
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (canDrag)
        {
            Vector3 screenPosition = new Vector3(eventData.position.x, eventData.position.y, mainCamera.WorldToScreenPoint(player.transform.position).z);
            Vector3 worldPosition = mainCamera.ScreenToWorldPoint(screenPosition);

            player.transform.position = new Vector3(worldPosition.x, player.transform.position.y, player.transform.position.z);
        }
    }


    void Update()
    {
        
    }

    
}
