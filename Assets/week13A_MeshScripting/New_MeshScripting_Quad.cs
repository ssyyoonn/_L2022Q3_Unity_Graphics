using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_MeshScripting_Quad : MonoBehaviour
{
    public Vector3[] newVertices;
    public int[] newTriangles;
    // int�� ������ ����: �ﰢ�� ���� ���� Vertex�� index ���� ���

    void Start()
    {
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
