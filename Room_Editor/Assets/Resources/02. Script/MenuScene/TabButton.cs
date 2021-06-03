using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup MyTabGroup;

    public Image Background;

    public void OnPointerClick(PointerEventData eventData)
    {
        MyTabGroup.OnTabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        MyTabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        MyTabGroup.OnTabExit(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        Background = GetComponent<Image>();        
        MyTabGroup.Subscribe(this);
    }
}
