using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Locate_Start : MonoBehaviour
{
    public Transform CubeTransform;
    Camera TargetCamera;

    void Start()
    {
        // TargetCamera 라는 태그가 있는 카메라를 가져옴
        TargetCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayAtPoint();   
    }

    void DisplayAtPoint()
    {
        Vector3 WorldPos = CubeTransform.position; // Cube의 3D 월드 좌표값
        Vector2 ScreenPos = TargetCamera.WorldToScreenPoint(WorldPos + Vector3.up);
        // 3D공간 좌표를 스크린상 좌표로 변환해주는 메서드로 3D 좌표값의 2D 좌표값 구함
        transform.position = ScreenPos;
    }
}
