using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    Scene CurrentScene;
    public Object SceneToLoad; // ���� Object Ÿ��. inspector â���� �̵��ϰ� ���� ���� �Ҵ�
    void Start()
    {
        CurrentScene = gameObject.scene; // �� ��ũ��Ʈ�� ���� �ִ� ���� ������Ʈ�� ���� �ִ� ��
        print(CurrentScene.name);
    }


    private void OnMouseDown()
    {
        // SceneManager.LoadScene("LoadSceneTest02"); // ��Ż�� ���� ���� ����. �׷� ���� �Ʒ� ��� ���
        SceneManager.LoadScene(SceneToLoad.name);  // inspector â���� �̵��ϰ� ���� ���� �Ҵ�
    }
}
