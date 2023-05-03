using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Inventory.UI
{
    public class UIInventoryPage : MonoBehaviour
    {
        [SerializeField]
        private UIInventoryItem itemPrefab;
        [SerializeField]
        private RectTransform contentPanel;

        private Sprite yoshi;
        private TMP_Text name;

        public List<UIInventoryItem> listOfUIItems = new List<UIInventoryItem>();
        public List<InventoryItem> listOfUIItems = new List<InventoryItem>();


        public void InitializeInventoryUI(int inventorysize)
        {
            for(int i = 0; i < inventorysize; i++)
            {
                UIInventoryItem uiItem =
                    Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
                uiItem.transform.SetParent(contentPanel);
                listOfUIItems.Add(uiItem);
                Debug.Log("Length of List: " + listOfUIItems.Count);
            }
        }

        public void UpdateData(int itemIndex, Sprite itemImage, string itemName)
        {
            if (listOfUIItems.Count >= itemIndex && itemIndex < 16)
            {
                listOfUIItems[itemIndex].SetData(itemImage, itemName);
            }
        }

    }
}

