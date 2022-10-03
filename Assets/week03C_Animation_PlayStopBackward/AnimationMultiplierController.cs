using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMultiplierController : MonoBehaviour
{    
    Animator Anim;
    void Start()
    {
        string info = "[p] = play, [b] = play backwards, [s] = stop";
        print(info);

        Anim = GetComponent<Animator>();
        Anim.SetFloat("Dir", 0f); // Dir�̶�� �̸��� ���� �Ķ������ ���� ���ʷ� ��������
    }

    void Update()
    {
        /*****************************************************************
         * Unity KeyCode
         * https://docs.unity3d.com/kr/2020.3/ScriptReference/KeyCode.html
         *****************************************************************/
        if (Input.GetKeyDown(KeyCode.P)) // P ������ Dir �� 1�� ����
        {
            print("play");

            Anim.SetFloat("Dir", 1f); 
        }

        if (Input.GetKeyDown(KeyCode.B)) // B ������ Dir �� -1�� ���� (�����)
        {
            print("play backwards");

            Anim.SetFloat("Dir", -1f);
        }

        if (Input.GetKeyDown(KeyCode.S)) // S ������ Dir �� 0�� ���� (����)
        {            
            print("stop");

            Anim.SetFloat("Dir", 0f);
        }
    }
}