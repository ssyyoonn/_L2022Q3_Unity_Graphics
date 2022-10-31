using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene_OnMouseDown: MonoBehaviour
{
    public Object SceneToLoad;
    Scene CurrentScene; // 씬은 Object 타입. 

    void Start()
    {
        CurrentScene = gameObject.scene;
        print("CurrentScene = " + CurrentScene.name + ", gameObject = " + gameObject.name); // 이 스크립트를 갖고 있는 게임 오브젝트가 속해 있는 씬 + 게임오브젝트의 이름
    }

    private void OnMouseDown()
    {
        // SceneManager.LoadScene("LoadSceneTest02"); // 오탈자 있을 수도 있음. 그럴 떄는 아래 방법 사용
        SceneManager.LoadScene(SceneToLoad.name); // inspector 창에서 이동하고 싶은 씬을 할당
    }
}
