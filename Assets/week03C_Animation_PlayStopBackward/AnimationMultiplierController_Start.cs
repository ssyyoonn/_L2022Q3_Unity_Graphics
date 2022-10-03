using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMultiplierController_Start : MonoBehaviour
{
    Animator Anim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        Anim.SetFloat("Dir", 0f);  // Dir�̶�� �̸��� ���� �Ķ������ ���� ���ʷ� ��������
    }

    // Update is called once per frame
    void Update()
    {
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

