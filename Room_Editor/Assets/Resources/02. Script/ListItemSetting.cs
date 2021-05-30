using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using static FurnitureList;

public class ListItemSetting : MonoBehaviour
{
    public FuniterModel FuniterInfo { get; set; }

    public void ItemSetting()
    {
        if (FuniterInfo != null)
        {
            var itemsprite = Resources.Load<Sprite>(FuniterInfo.Image);

            var image = transform.Find("Image");
            image.GetComponent<Image>().sprite = itemsprite;

            var title = transform.Find("ItemName");
            title.GetComponent<Text>().text = FuniterInfo.Title;
        }
    }

    

    private void OnMouseOver()
    {
        EventSystem.current.IsPointerOverGameObject();
    }
}
