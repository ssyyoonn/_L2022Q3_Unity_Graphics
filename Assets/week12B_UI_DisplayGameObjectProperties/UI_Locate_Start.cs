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
        // TargetCamera ��� �±װ� �ִ� ī�޶� ������
        TargetCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayAtPoint();   
    }

    void DisplayAtPoint()
    {
        Vector3 WorldPos = CubeTransform.position; // Cube�� 3D ���� ��ǥ��
        Vector2 ScreenPos = TargetCamera.WorldToScreenPoint(WorldPos + Vector3.up);
        // 3D���� ��ǥ�� ��ũ���� ��ǥ�� ��ȯ���ִ� �޼���� 3D ��ǥ���� 2D ��ǥ�� ����
        transform.position = ScreenPos;
    }
}
