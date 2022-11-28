using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Start_Slider : MonoBehaviour
{
    public GameObject MyGameObject;
    Material MyMaterial;

    void Start()
    {   
        // MyGameObject�� �Ҵ�� material�� ������
        MyMaterial = MyGameObject.GetComponent<Renderer>().material;
    }

    void Update()
    {
       
    }

    public void OnValueChanged_SetColor()
    {
        float val = GetComponent<Slider>().value;
        print(val);
        Color c = new Color(val, val, val, 1);
        MyMaterial.SetColor("_Color", c); // _Color��� ������ c �� ����
    } 
}
