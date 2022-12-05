using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_MeshScripting_Diamond : MonoBehaviour
{
    void Start()
    {
        Vector3 V0, V1, V2, V3, V4, V5;
        Vector3[] newVertices;
        int[] newTriangles;

        V0 = new Vector3(0, 0, -1);
        V1 = new Vector3(0, 0, 0);
        V2 = new Vector3(1, 0, 0);
        V3 = new Vector3(1, 0, -1);
        V4 = new Vector3(0.5f, 1, -0.5f);
        V5 = new Vector3(0.5f, -1, -0.5f);

        newVertices = new Vector3[]
        {
            V0, V1, V2, V3, V4, V5
        };

        newTriangles = new int[]
        {
            4, 3, 0,    // ��-��
            4, 2, 3,    // ��-��
            4, 1, 2,    // ��-��
            4, 0, 1,    // ��-��
            0, 3, 5,    // ��-��
            3, 2, 5,    // ��-��
            2, 1, 5,    // ��-��
            1, 0, 5     // ��-��
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh(); // Mesh ����
        GetComponent<MeshFilter>().mesh = mesh; // MeshFilter�� mesh ���� ������ mesh�� �ʱ�ȭ
        mesh.vertices = newVertices;    //// inspector���� ������ ����
        mesh.triangles = newTriangles;  //// vertices, triangles �� �Ҵ�

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;
    }
}
