using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelActive : MonoBehaviour
{
    RectTransform ThisRect;

    Vector3 ShowPos = new Vector3(0, -1000, 0);

    private Vector3 buttonVelocity = Vector3.zero;

    public float SmoothTime = 0.5f;

    private CanvasGroup MyCanvasGrp;

    public bool IsShow = false;
    
    public void Start()
    {        
        ThisRect = GetComponent<RectTransform>();
        MyCanvasGrp = GetComponent<CanvasGroup>();
    }

    private void Update()
    {
        if (IsShow)
        {
            MyCanvasGrp.alpha = Mathf.Lerp(MyCanvasGrp.alpha, 1, Time.deltaTime);
            //ThisRect.localScale = Vector3.Lerp(transform.localScale, new Vector3(1, 1, 1), SmoothTime);
            //ThisRect.localPosition = Vector3.SmoothDamp(ThisRect.localPosition, new Vector3(0, 0, 0),  ref buttonVelocity, SmoothTime);
        }
        else
        {
            MyCanvasGrp.alpha = Mathf.Lerp(MyCanvasGrp.alpha, 0, Time.deltaTime);
            //ThisRect.localScale = Vector3.Lerp(transform.localScale, new Vector3(0, 0, 0), SmoothTime);
            //ThisRect.localPosition = Vector3.SmoothDamp(ThisRect.localPosition, ShowPos , ref buttonVelocity, SmoothTime);
        }
    }   
}
