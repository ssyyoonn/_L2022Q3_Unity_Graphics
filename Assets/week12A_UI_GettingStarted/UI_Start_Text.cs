using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // GetComponent<Text> �� ����ϱ� ���� �ʿ�
                       // ��, UI ������Ʈ�� �����ϱ� ���� namespace �߰�

public class UI_Start_Text : MonoBehaviour
{
    public GameObject MyGameObject;
   
    void Start()
    {
        string name = MyGameObject.name;    // �Ҵ��� MyGameObject�� �̸�
        name += " made by yoon";
        GetComponent<Text>().text = name;
    }

    void Update()
    {
        
    }
}
