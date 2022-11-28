using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Start_Button : MonoBehaviour
{
    public InputField InputFieldComponent; // GameObject�� inputfield ������Ʈ�� �ٷ� �Ҵ�ް�
    public Text TextComponent; // Text ������Ʈ �ٷ� �Ҵ�ް�

    public void OnClick_SetText()
    {
        TextComponent.text = InputFieldComponent.text;
    }
}
