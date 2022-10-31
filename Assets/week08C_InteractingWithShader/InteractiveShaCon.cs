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
        MyRenderer.material.SetInt("_Brightness", brightness); // 초기 Brightness 값 1로 설정
    }

    private void OnMouseDown()
    {
        brightness = -1 * brightness;  // 클릭하면 brightness 값에 -1 곱함 (1이면 -1, -1이면 1로)
        MyRenderer.material.SetInt("_Brightness", brightness); // 클릭시 Brightness 값 변경
    }
}
