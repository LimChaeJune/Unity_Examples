using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FurnitureList : MonoBehaviour
{
    [SerializeField]
    private GameObject ListFormat;

    public class FuniterModel
    {
        public string Image { get; set; }
        public string Title { get; set; }
    }

    // Start is called before the first frame update
    void Start()
    {
        List<FuniterModel> funiters = new List<FuniterModel>();
        funiters.Add(new FuniterModel { Image = "05. Images/Chair", Title = "����" });
        funiters.Add(new FuniterModel { Image = "05. Images/Closet", Title = "����" });
        funiters.Add(new FuniterModel { Image = "05. Images/EllipseTable", Title = "���� ���̺�" });
        funiters.Add(new FuniterModel { Image = "05. Images/RectTable", Title = "�簢 ���̺�" });
        funiters.Add(new FuniterModel { Image = "05. Images/Lamp", Title = "����" });

        foreach(var item in funiters)
        {
            var setting = ListFormat.GetComponent<ListItemSetting>();
            setting.FuniterInfo = item;
            setting.ItemSetting();
            ListFormat.SetActive(true);

            var instance = Instantiate(ListFormat, new Vector3(0, 0, 0), Quaternion.identity);
            instance.transform.SetParent(transform);
        }        
    }
}
