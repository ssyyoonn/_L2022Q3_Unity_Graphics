using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Start_Toggle : MonoBehaviour
{
    Material MyMaterial;
    public GameObject MyGameObject;
    bool isOn;
    Color c1, c2;

    void Start()
    {
        MyMaterial = MyGameObject.GetComponent<Renderer>().material;
        c1 = new Color(1, 1, 1, 1); // ÇÏ¾á»ö
        c2 = new Color(1, 0, 0, 1); // »¡°£»ö
    }

    public void OnValueChanged_SetColor()
    {
        isOn = GetComponent<Toggle>().isOn;
        if (isOn)
        {
            MyMaterial.SetColor("_Color", c1);

        }
        else
        {
            MyMaterial.SetColor("_Color", c2);
        }
        print(isOn);
    }
}
