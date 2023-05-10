using UnityEngine;
using UnityEngine.UI;

public class AddItemToCanvas : MonoBehaviour
{
    public GameObject itemPrefab; // the prefab of the item to add
    public GridLayoutGroup gridLayoutGroup; // the grid layout group of the canvas
    public int maxItemsPerRow = 3; // the maximum number of items per row in the grid

    private void Start()
    {
        // get the grid layout group of the canvas if not already set
        if (gridLayoutGroup == null)
        {
            gridLayoutGroup = GetComponent<GridLayoutGroup>();
        }
    }

    public void AddItem()
    {
        // instantiate the new item as a child of the canvas
        GameObject newItem = Instantiate(itemPrefab, transform);

        // set the item's position based on the grid layout group
        int itemCount = transform.childCount;
        int row = (itemCount - 1) / maxItemsPerRow;
        int column = (itemCount - 1) % maxItemsPerRow;
        Vector2 itemPosition = new Vector2(column * gridLayoutGroup.cellSize.x + column * gridLayoutGroup.spacing.x,
                                           -row * gridLayoutGroup.cellSize.y - row * gridLayoutGroup.spacing.y);
        newItem.GetComponent<RectTransform>().anchoredPosition = itemPosition;

        // set the item's size to 10% of the grid cell size
        //newItem.GetComponent<RectTransform>().sizeDelta = gridLayoutGroup.cellSize * 0.1f;
    }
}
