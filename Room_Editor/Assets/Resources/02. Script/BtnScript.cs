using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BtnScript : MonoBehaviour
{
    private Button btn;
    [SerializeField]
    private GameObject Target_gameobj;
    [SerializeField]
    private string Value;

    // Start is called before the first frame update
    void Start()
    {        
        btn = GetComponent<Button>();
        this.GetComponentInChildren<Text>().text = Value;
        btn.onClick.AddListener(Btn_Click);
    }

    // Update is called once per frame
    void Update()
    {       
    }

    private void OnMouseDown()
    {
      
    }

    public void Btn_Click()
    {
            switch (this.Value)
            {
                case "Cube":
                    GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    cube.transform.parent = Target_gameobj.transform;
                    cube.transform.position = Target_gameobj.transform.position + new Vector3(0, 1, 0);
                    cube.AddComponent<ObjectDrag>();
                    break;
                case "Sphere":
                    GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                    sphere.transform.parent = Target_gameobj.transform;
                    sphere.transform.position = Target_gameobj.transform.position + new Vector3(0, 1, 0);
                    sphere.AddComponent<ObjectDrag>();
                    break;
                case "Capsule":
                    GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                    capsule.transform.parent = Target_gameobj.transform;
                    capsule.transform.position = Target_gameobj.transform.position + new Vector3(0, 1, 0);
                    capsule.AddComponent<ObjectDrag>();
                    break;
                case "Cylinder":
                    GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                    cylinder.transform.parent = Target_gameobj.transform;
                    cylinder.transform.position = Target_gameobj.transform.position + new Vector3(0, 1, 0);
                    cylinder.AddComponent<ObjectDrag>();
                    break;
            }
        
    }
}
