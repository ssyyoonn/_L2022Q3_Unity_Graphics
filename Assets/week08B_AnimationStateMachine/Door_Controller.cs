using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    public GameObject Pivot;


    //private void OnCollisionEnter(Collision collision)
    //{
    //    print(collision.gameObject.name); // 충돌한 gameobject 이름 출력
    //}

    private void OnTriggerEnter(Collider other) // Trigger 안에 들어옴
    {
        print("enter "+other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }
    private void OnTriggerExit(Collider other) // Trigger 벗어남
    {
        print("exit " + other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 2);
    }
}
