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
            4, 3, 0,    // 상-전
            4, 2, 3,    // 상-우
            4, 1, 2,    // 상-후
            4, 0, 1,    // 상-좌
            0, 3, 5,    // 하-전
            3, 2, 5,    // 하-우
            2, 1, 5,    // 하-후
            1, 0, 5     // 하-좌
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
