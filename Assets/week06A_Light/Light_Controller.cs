using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Controller : MonoBehaviour
{
    public GameObject Light;
    bool isOn;
    void Start()
    {
        isOn = false; // ������ �� ���� ����
        Light.SetActive(isOn);
    }

    // Update is called once per frame
    void Update()
    {
        // Ű �Է����� ���� ����
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("L down");

            isOn = !isOn;   // true�� false��, false�� true�� �ٲ���
            Light.SetActive(isOn);
        }
    }
    
    // ����ڰ� �ش� ��ũ��Ʈ�� ������ �ִ� ������Ʈ�� Ŭ���� ���� ������ �����
    private void OnMouseDown()
    {
        print("mouse down " + gameObject.name);
        isOn = !isOn;   // true�� false��, false�� true�� �ٲ���
        Light.SetActive(isOn);
    }

}
