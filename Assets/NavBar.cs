using UnityEngine;
using UnityEngine.UI;

public class NavBar : MonoBehaviour
{
    public Canvas InventoryDisplay; // assign the canvas to disable in the Inspector
    public Button InventoryButton; 
    public Button ARButton; 

    private void Start()
    {
        // add a listener to the button's click event
        InventoryButton.onClick.AddListener(DisableCanvasOnClick);
        ARButton.onClick.AddListener(EnableCanvasOnClick);
    }

    private void DisableCanvasOnClick()
    {
        InventoryDisplay.gameObject.SetActive(true);
    }

    private void EnableCanvasOnClick()
    {
        InventoryDisplay.gameObject.SetActive(false);
    }
}
