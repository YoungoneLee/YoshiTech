using UnityEngine;
using UnityEngine.UI;

public class AddItemsToGrid : MonoBehaviour
{
    public GameObject itemPrefab; // assign the prefab of the item to add in the Inspector
    public RectTransform gridTransform; // assign the RectTransform of the grid layout in the Inspector
    public int numColumns = 2; // the number of columns in the grid layout
    public float padding = 10f; // the padding between items in the grid layout

    private int numItems = 0; // keep track of the number of items added to the grid

    public void AddItemToGrid()
    {
        // instantiate a new item from the assigned prefab
        GameObject newItem = Instantiate(itemPrefab, gridTransform);

        // set the position of the new item in the grid layout
        int row = Mathf.FloorToInt(numItems / numColumns);
        int col = numItems % numColumns;
        float x = col * (newItem.GetComponent<RectTransform>().rect.width + padding);
        float y = -row * (newItem.GetComponent<RectTransform>().rect.height + padding);
        newItem.GetComponent<RectTransform>().anchoredPosition = new Vector2(x, y);

        // increment the number of items added to the grid
        numItems++;
    }
}
