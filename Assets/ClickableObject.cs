using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using System.Collections;
using System.Collections.Generic;
using Inventory.UI;
using UnityEngine.UI;

public class ClickableObject : MonoBehaviour
{
    public GameObject uiObject;
    private ARRaycastManager raycastManager;
    private ARTrackedObjectManager trackedObjectManager;
    private bool isObjectClicked = false;

    public Sprite[] images;
    public string[] names = { "Dr. Tan", "Dr. Fogarty", "Dr. Horn", "Dr. Myers", "Dr. Zhang", "Dr. Hibbs", "Dr. Lewis", "Dr. Tuba", "Wen", "Janet", "Dohoon", "Konstantine", "Nathan", "Tray", "Quang", "Leah", "Christian", "Donya", "Brandon", "Jose", "Ashwin", "Ashley", "Julia", "Casey", "Agustin" };

    [SerializeField]
    private UIInventoryPage inventoryUI;
    public int inventorySize = 16;
    public int cnt = 0;

    void Start()
    {
        raycastManager = GetComponent<ARRaycastManager>();
        trackedObjectManager = FindObjectOfType<ARTrackedObjectManager>();
        uiObject.SetActive(false);
        inventoryUI.InitializeInventoryUI(inventorySize);
    }

    void Update()
    {
        rotateYoshi();
        if (trackedObjectManager == null)
            return;

        if (!isObjectClicked && Input.touchCount == 1)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit[] hits = new RaycastHit[1];
                if (Physics.Raycast(ray, out hits[0]))
                {
                    if (hits[0].collider.gameObject == gameObject)
                    {
                        isObjectClicked = true;
                        uiObject.SetActive(true);
                        gameObject.SetActive(false);
                        Invoke("ShowObject", 5f);
                        AddTheYosh();
                    }
                }
            }
        }
    }

    void ShowObject()
    {
        uiObject.SetActive(false);
        gameObject.SetActive(true);
        isObjectClicked = false;
    }

    void rotateYoshi()
    {
        this.transform.Rotate(0, 1, 0);
    }

    public void AddTheYosh()
    {
        int randColor = Random.Range(0, images.Length - 1);
        int randName = Random.Range(0, names.Length - 1);
        inventoryUI.UpdateData(cnt, images[randColor], names[randName]);
        cnt++;
    }
}
