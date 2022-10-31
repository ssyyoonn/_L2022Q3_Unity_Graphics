using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveShaCon : MonoBehaviour
{
    int brightness = 1;
    Renderer MyRenderer;
    // Start is called before the first frame update
    void Start()
    {
        MyRenderer = gameObject.GetComponent<Renderer>();
        MyRenderer.material.SetInt("_Brightness", brightness); // �ʱ� Brightness �� 1�� ����
    }

    private void OnMouseDown()
    {
        brightness = -1 * brightness;  // Ŭ���ϸ� brightness ���� -1 ���� (1�̸� -1, -1�̸� 1��)
        MyRenderer.material.SetInt("_Brightness", brightness); // Ŭ���� Brightness �� ����
    }
}
