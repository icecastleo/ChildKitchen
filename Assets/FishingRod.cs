using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class FishingRod : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Vector3 _startPosition;
    Vector3 _offsetToMouse;
    float distance = 4.0F;

    public float timeStart;
    public float nextFish;

    SpriteRenderer wait;
    SpriteRenderer find;

    public GameObject[] fishes;

    // Use this for initialization
    void Start () {
        _startPosition = transform.position;
        wait = transform.FindChild("Wait").GetComponent<SpriteRenderer>();
        find = transform.FindChild("Find").GetComponent<SpriteRenderer>();

        //Debug.Log("Start");
    }

    void OnEnable()
    {
        timeStart = Time.time;
        nextFish = timeStart + Random.Range(3, 5);
        //Debug.Log("script was enabled");
    }

    // Update is called once per frame
    void Update () {
        if (Time.time < nextFish)
        {
            find.enabled = false;
            wait.enabled = true;
        } else if (Time.time < nextFish + 3)
        {
            wait.enabled = false;
            find.enabled = true;
        } else
        {
            timeStart = Time.time;
            nextFish = timeStart + Random.Range(3, 5);
        }
    }

    #region Interface Implementations

    public void OnBeginDrag(PointerEventData eventData)
    {
        GetComponent<Rigidbody2D>().simulated = false;

        foreach (Touch touch in Input.touches)
        {            
            _offsetToMouse = _startPosition - Camera.main.ScreenToWorldPoint(
                new Vector3(touch.position.x, touch.position.y, 0)
            );
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        foreach (Touch touch in Input.touches)
        {
            transform.position = Camera.main.ScreenToWorldPoint(
                new Vector3(touch.position.x, touch.position.y, 0)
                ) + _offsetToMouse;
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<Rigidbody2D>().simulated = true;
        _offsetToMouse = Vector3.zero;

        Debug.Log(Vector3.Distance(transform.position, _startPosition));

        if (Vector3.Distance(transform.position, _startPosition) > distance)
        {
            transform.gameObject.SetActive(false);
        } else
        {
            if(find.enabled == true)
            {
                GameObject fish = Instantiate(fishes[Random.Range(0, fishes.Length)], transform.position, Quaternion.identity);
                fish.GetComponent<Rigidbody2D>().AddForce(new Vector2(transform.position.x - _startPosition.x, transform.position.y - _startPosition.y));
            }
        }

        transform.position = _startPosition;
    }

    #endregion

    void OnMouseDown()
    {
        _offsetToMouse = _startPosition - Camera.main.ScreenToWorldPoint(
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)
        );
    }

    void OnMouseDrag()
    {
        transform.position = Camera.main.ScreenToWorldPoint(
              new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0)
              ) + _offsetToMouse;
    }

    void onMouseUp()
    {
        _offsetToMouse = Vector3.zero;
    }
}
