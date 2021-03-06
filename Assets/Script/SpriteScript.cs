﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SpriteScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //public static GameObject DraggedInstance;
    //public static bool isDragged;

    Vector3 _startPosition;
    Vector3 _offsetToMouse;
    float _zDistanceToCamera;

    // Use this for initialization
    void Start() {

    }

    #region Interface Implementations

    public void OnBeginDrag(PointerEventData eventData)
    {
        transform.localEulerAngles = new Vector3(0, 0, 0);

        //if (Input.touchCount != 1)
        //    return;

        GetComponent<Rigidbody2D>().simulated = false;

        //foreach (Collider2D c in GetComponents<Collider2D>())
        //{
        //    Debug.Log("trigger to move");
        //    //c.isTrigger = true;
        //}

        foreach (Touch touch in Input.touches)
        {
            //DraggedInstance = gameObject;
            //isDragged = true;

            _startPosition = transform.position;
            //_zDistanceToCamera = Mathf.Abs(_startPosition.z - Camera.main.transform.position.z);

            _offsetToMouse = _startPosition - Camera.main.ScreenToWorldPoint(
                new Vector3(touch.position.x, touch.position.y, 0)
            );
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        //if (Input.touchCount != 1)
        //    return;

        foreach (Touch touch in Input.touches)
        {
            transform.position = Camera.main.ScreenToWorldPoint(
                new Vector3(touch.position.x, touch.position.y, 0)
                ) + _offsetToMouse;
        }

        //    if (Input.touchCount == 1)
        //{
        //    //Debug.Log( + " " + );
        //    Debug.Log(Input.GetTouch(0).deltaPosition.x + " " + Input.GetTouch(0).deltaPosition.y);
        //    transform.position += new Vector3(Input.GetTouch(0).deltaPosition.x, Input.GetTouch(0).deltaPosition.y);
        //}
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        //if (Input.touchCount != 1)
        //    return;

        GetComponent<Rigidbody2D>().simulated = true;

        //foreach (Collider2D c in GetComponents<Collider2D>())
        //{
        //    Debug.Log("trigger to move");
        //    //c.isTrigger = false;
        //}

        //isDragged = false;
        //DraggedInstance = null;
        _offsetToMouse = Vector3.zero;
    }

    #endregion

    void OnMouseDown()
    {
        transform.localEulerAngles = new Vector3(0, 0, 0);

        _startPosition = transform.position;
        //_zDistanceToCamera = Mathf.Abs(_startPosition.z - Camera.main.transform.position.z);

        _offsetToMouse = _startPosition - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)
        );
    }

    void OnMouseDrag()
    {
        //DraggedInstance = gameObject;
        //isDragged = true;

        transform.position = Camera.main.ScreenToWorldPoint(
              new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)
              ) + _offsetToMouse;
    }

    void onMouseUp()
    {
        //isDragged = false;
        //DraggedInstance = null;
        _offsetToMouse = Vector3.zero;
    }

    // Update is called once per frame
    void Update () {

      

    }
}
