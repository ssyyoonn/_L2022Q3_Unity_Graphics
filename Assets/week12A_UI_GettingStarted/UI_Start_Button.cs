using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Start_Button : MonoBehaviour
{
    public InputField InputFieldComponent; // GameObject의 inputfield 컴포넌트를 바로 할당받게
    public Text TextComponent; // Text 컴포넌트 바로 할당받게

    public void OnClick_SetText()
    {
        TextComponent.text = InputFieldComponent.text;
    }
}
