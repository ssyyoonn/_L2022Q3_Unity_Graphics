using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene_OnMouseDown: MonoBehaviour
{
    public Object SceneToLoad;
    Scene CurrentScene; // ���� Object Ÿ��. 

    void Start()
    {
        CurrentScene = gameObject.scene;
        print("CurrentScene = " + CurrentScene.name + ", gameObject = " + gameObject.name); // �� ��ũ��Ʈ�� ���� �ִ� ���� ������Ʈ�� ���� �ִ� �� + ���ӿ�����Ʈ�� �̸�
    }

    private void OnMouseDown()
    {
        // SceneManager.LoadScene("LoadSceneTest02"); // ��Ż�� ���� ���� ����. �׷� ���� �Ʒ� ��� ���
        SceneManager.LoadScene(SceneToLoad.name); // inspector â���� �̵��ϰ� ���� ���� �Ҵ�
    }
}
