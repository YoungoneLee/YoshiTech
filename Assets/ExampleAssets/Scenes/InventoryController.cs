using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Inventory.UI;

namespace Inventory
{
    public class InventoryController : MonoBehaviour
    {
        [SerializeField]
        private UIInventoryPage inventoryUI;

        public int inventorySize = 16;

        private void Start()
        {
            //inventoryUI.InitializeInventoryUI(inventorySize);
        }

        private vod PrepareInventoryData()
        {
            inventoryData.Initialize();
        }

    }
}