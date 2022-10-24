using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Controller : MonoBehaviour
{
    public GameObject Light;
    bool isOn;
    void Start()
    {
        isOn = false; // 시작할 때 꺼진 상태
        Light.SetActive(isOn);
    }

    // Update is called once per frame
    void Update()
    {
        // 키 입력으로 조명 제어
        if (Input.GetKeyDown(KeyCode.L))
        {
            print("L down");

            isOn = !isOn;   // true면 false로, false면 true로 바꿔줌
            Light.SetActive(isOn);
        }
    }
    
    // 사용자가 해당 스크립트를 가지고 있는 오브젝트를 클릭시 안의 내용이 실행됨
    private void OnMouseDown()
    {
        print("mouse down " + gameObject.name);
        isOn = !isOn;   // true면 false로, false면 true로 바꿔줌
        Light.SetActive(isOn);
    }

}
