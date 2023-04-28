using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.EventSystems;

namespace Inventory.UI
{
    public class UIInventoryItem : MonoBehaviour
    {
        [SerializeField]
        private Image itemImage;
        [SerializeField]
        private TMP_Text nameTxt;
        //private TMP_Text nameTxt;

        public void SetData(Sprite sprite, string name)
        {
            itemImage.gameObject.SetActive(true);
            itemImage.sprite = sprite;
            nameTxt.text = "" + name;
            //empty = false;
        }
    }
}