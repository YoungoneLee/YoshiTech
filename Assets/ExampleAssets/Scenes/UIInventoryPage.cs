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

        List<UIInventoryItem> listOfUIItems = new List<UIInventoryItem>();

        public void InitializeInventoryUI(int inventorysize)
        {
            for(int i = 0; i < inventorysize; i++)
            {
                UIInventoryItem uiItem =
                    Instantiate(itemPrefab, Vector3.zero, Quaternion.identity);
                uiItem.transform.SetParent(contentPanel);
                listOfUIItems.Add(uiItem);
            }
        }

        /*
        public void UpdateData(int itemIndex,
            Sprite itemImage, string itemName)
        {
            if (listOfUIItems.Count > itemIndex)
            {
                listOfUIItems[itemIndex].SetData(itemImage, itemName);
            }
        }
        */
    }
}

