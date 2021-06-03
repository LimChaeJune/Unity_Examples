using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActive : MonoBehaviour
{
    RectTransform ThisRect;

    Vector3 ShowPos = new Vector3(0, -1000, 0);

    private Vector3 buttonVelocity = Vector3.zero;

    public float SmoothTime = 0.5f;

    public bool IsShow = false;
    
    public void Start()
    {        
        ThisRect = GetComponent<RectTransform>();        
    }

    private void Update()
    {
        if (IsShow)
        {
            ThisRect.localPosition = Vector3.SmoothDamp(ThisRect.localPosition, new Vector3(0, 0, 0),  ref buttonVelocity, SmoothTime);
        }
        else
        {
            ThisRect.localPosition = Vector3.SmoothDamp(ThisRect.localPosition, ShowPos , ref buttonVelocity, SmoothTime);
        }
    }   
}
