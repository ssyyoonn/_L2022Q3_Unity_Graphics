using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_MeshScripting_Cube : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7;
    Vector3[] newVertices;
    int[] newTriangles;
    void Start()
    {
        V0 = new Vector3(-0.5f, -0.5f, -0.5f);
        V1 = new Vector3(-0.5f, -0.5f, 0.5f);
        V2 = new Vector3(0.5f, -0.5f, 0.5f);
        V3 = new Vector3(0.5f, -0.5f, -0.5f);
        V4 = new Vector3(-0.5f, 0.5f, -0.5f);
        V5 = new Vector3(-0.5f, 0.5f, 0.5f);
        V6 = new Vector3(0.5f, 0.5f, 0.5f);
        V7 = new Vector3(0.5f, 0.5f, -0.5f);

        newVertices = new Vector3[]
        {
            V0, V1, V2, V3, V4, V5, V6, V7
        };

        newTriangles = new int[]
        {
            // front
            0, 4, 7,
            0, 7, 3,
            // right
            3, 7, 2,
            2, 7, 6,
            // back
            1, 6, 5,
            1, 2, 6,
            // left
            1, 5, 4,
            1, 4, 0,
            // top
            4, 5, 6,
            4, 6, 7,
            // bottom
            0, 2, 1,
            0, 3, 2     

        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh(); // Mesh 생성
        GetComponent<MeshFilter>().mesh = mesh; // MeshFilter의 mesh 값을 생성한 mesh로 초기화
        mesh.vertices = newVertices;    //// inspector에서 지정한 값을
        mesh.triangles = newTriangles;  //// vertices, triangles 로 할당

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;
    }
}
