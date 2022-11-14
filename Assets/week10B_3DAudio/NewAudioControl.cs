using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAudioControl : MonoBehaviour
{
    AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();    // ��ũ��Ʈ�� �߰��� ������Ʈ�� �Ҵ�� ������� ������
        Audio.Play();   // �������� �� �÷��̵ǵ��� (�������·� �ϰ� ������ .Stop()����)
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))    // P ������ ���
        {
            Audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))    // S ������ ����
        {
            Audio.Stop();
        }
    }
}
