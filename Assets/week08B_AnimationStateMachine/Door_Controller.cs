using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Controller : MonoBehaviour
{
    public GameObject Pivot;


    //private void OnCollisionEnter(Collision collision)
    //{
    //    print(collision.gameObject.name); // �浹�� gameobject �̸� ���
    //}

    private void OnTriggerEnter(Collider other) // Trigger �ȿ� ����
    {
        print("enter "+other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 1);
    }
    private void OnTriggerExit(Collider other) // Trigger ���
    {
        print("exit " + other.name);
        Pivot.GetComponent<Animator>().SetInteger("State", 2);
    }
}
