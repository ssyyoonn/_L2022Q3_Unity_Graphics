using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewAudioControl : MonoBehaviour
{
    AudioSource Audio;

    void Start()
    {
        Audio = GetComponent<AudioSource>();    // 스크립트가 추가된 오브젝트에 할당된 오디오를 가져옴
        Audio.Play();   // 시작했을 때 플레이되도록 (정지상태로 하고 싶으면 .Stop()으로)
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))    // P 누르면 재생
        {
            Audio.Play();
        }
        if (Input.GetKeyDown(KeyCode.S))    // S 누르면 정지
        {
            Audio.Stop();
        }
    }
}
