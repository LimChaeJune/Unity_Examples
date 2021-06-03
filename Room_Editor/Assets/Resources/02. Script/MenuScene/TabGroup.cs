using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TabGroup : MonoBehaviour
{
    public List<TabButton> ButtonList;
    public Color tabIdle;
    public Color tabHover;
    public Color tabActive;
    public TabButton selectedTab;
    public List<GameObject> objectToSwap;

    public void Subscribe(TabButton button)
    {
        if(ButtonList == null)
        {
            ButtonList = new List<TabButton>();
        }

        ButtonList.Add(button);
    }

    public void OnTabEnter(TabButton button)
    {
        ResetTabs();
        if (selectedTab == null || button != selectedTab)
        {
            button.Background.color = tabHover;
        }
    }
    public void OnTabSelected(TabButton button)
    {
        selectedTab = button;
        ResetTabs();
        button.Background.color = tabActive;
        int index = button.transform.GetSiblingIndex();
        for(int i=0; i<objectToSwap.Count; i++)
        {
            if(i == index)
            {
                objectToSwap[i].GetComponent<PanelActive>().IsShow = true;
            }
            else
            {
                objectToSwap[i].GetComponent<PanelActive>().IsShow = false;
            }
        }
    }

    public void OnTabExit(TabButton button)
    {
        ResetTabs();

    }

    public void ResetTabs()
    {
        foreach(TabButton button in ButtonList)
        {
            if(selectedTab != null && button == selectedTab) { continue; }
            button.Background.color = tabIdle;
        }
    }
}
