using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlideMenu : MonoBehaviour
{    
    [SerializeField]
    private GameObject PanelMenu;
    [SerializeField]
    private bool UseShow;

    private void Start()
    {
        var btn = GetComponent<Button>();
        btn.onClick.AddListener(ShowHideMenu);                
    }


    public void ShowHideMenu()
    { 
        if(PanelMenu != null)
        {            
            Animator animator = PanelMenu.GetComponent<Animator>();
            if(animator != null)
            {                
                if (!UseShow)
                {                                        
                    transform.Translate(new Vector3(-90f, 0f, 0f));                    
                }
                else
                {
                    var btn = GameObject.Find("Btn_ShowMenu");                    
                    btn.transform.Translate(new Vector3(90f, 0f, 0f));                    
                }
                animator.SetBool("Show", UseShow);
            }
        }
    }

    public void Update()
    {         
       
    }


}
