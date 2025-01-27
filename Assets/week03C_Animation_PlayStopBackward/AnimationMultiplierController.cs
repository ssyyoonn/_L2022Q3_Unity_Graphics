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
        Anim.SetFloat("Dir", 0f); // Dir이라는 이름을 가진 파라미터의 값을 최초로 설정해줌
    }

    void Update()
    {
        /*****************************************************************
         * Unity KeyCode
         * https://docs.unity3d.com/kr/2020.3/ScriptReference/KeyCode.html
         *****************************************************************/
        if (Input.GetKeyDown(KeyCode.P)) // P 누르면 Dir 값 1로 변경
        {
            print("play");

            Anim.SetFloat("Dir", 1f); 
        }

        if (Input.GetKeyDown(KeyCode.B)) // B 누르면 Dir 값 -1로 변경 (역재생)
        {
            print("play backwards");

            Anim.SetFloat("Dir", -1f);
        }

        if (Input.GetKeyDown(KeyCode.S)) // S 누르면 Dir 값 0로 변경 (정지)
        {            
            print("stop");

            Anim.SetFloat("Dir", 0f);
        }
    }
}
