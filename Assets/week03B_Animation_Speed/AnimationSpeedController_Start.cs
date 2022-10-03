using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedController_Start : MonoBehaviour
{
    Animator Anim; // Animator는 type, Anime은 객체 이름
    void Start() // 처음 한번만 실행되는 코드
    {
        Anim = GetComponent<Animator>(); // Animator라는 component를 불러오는 코드
        Anim.speed = 0.0f; // 애니메이션 재생 속도를 0으로. play 누르면 애니메이션이 멈춰있도록 함 
    }

    // Update is called once per frame
    void Update() // start 실행 이후 반복해서 실행되는 코드
    {
        // 사용자가 어떤 키를 눌렀는지는 계속 update를 하면서 추적해야 함
        if(Input.GetKeyDown(KeyCode.P)) // 만약 P라는 키를 눌렀다면
        {
            print("play");
            Anim.speed = 1.0f;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("stop");
            Anim.speed = 0.0f;
        }
        if (Input.GetKeyDown(KeyCode.Q)) // Q를 누르면 속도가 2배
        {
            print("speed 2");
            Anim.speed = 2.0f;
        }
    }
}


