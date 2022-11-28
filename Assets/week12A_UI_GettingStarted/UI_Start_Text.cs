using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // GetComponent<Text> 를 사용하기 위해 필요
                       // 즉, UI 컴포넌트에 접근하기 위해 namespace 추가

public class UI_Start_Text : MonoBehaviour
{
    public GameObject MyGameObject;
   
    void Start()
    {
        string name = MyGameObject.name;    // 할당한 MyGameObject의 이름
        name += " made by yoon";
        GetComponent<Text>().text = name;
    }

    void Update()
    {
        
    }
}
