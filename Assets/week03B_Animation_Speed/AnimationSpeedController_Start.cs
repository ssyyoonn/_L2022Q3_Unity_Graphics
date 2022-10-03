using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController_Start : MonoBehaviour
{
    Animator Anim; // Animator�� type, Anime�� ��ü �̸�
    void Start() // ó�� �ѹ��� ����Ǵ� �ڵ�
    {
        Anim = GetComponent<Animator>(); // Animator��� component�� �ҷ����� �ڵ�
        Anim.speed = 0.0f; // �ִϸ��̼� ��� �ӵ��� 0����. play ������ �ִϸ��̼��� �����ֵ��� �� 
    }

    // Update is called once per frame
    void Update() // start ���� ���� �ݺ��ؼ� ����Ǵ� �ڵ�
    {
        // ����ڰ� � Ű�� ���������� ��� update�� �ϸ鼭 �����ؾ� ��
        if(Input.GetKeyDown(KeyCode.P)) // ���� P��� Ű�� �����ٸ�
        {
            print("play");
            Anim.speed = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("stop");
            Anim.speed = 0.0f;
        }
        if (Input.GetKeyDown(KeyCode.Q)) // Q�� ������ �ӵ��� 2��
        {
            print("speed 2");
            Anim.speed = 2.0f;
        }
    }
}


