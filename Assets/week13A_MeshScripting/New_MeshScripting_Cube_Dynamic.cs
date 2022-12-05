using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_MeshScripting_Cube_Dynamic : MonoBehaviour
{
    Vector3 V0, V1, V2, V3, V4, V5, V6, V7;
    Vector3[] newVertices;
    int[] newTriangles;
    Vector3[] newNormals;

    public float speed = 0.001f; // speed 추가
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
            // Back 
            V0, V4, V7, V3, //0, 1, 2, 3 
            // Right 
            V3, V7, V6, V2, //4, 5, 6, 7 
            // Front 
            V2, V6, V5, V1, //8, 9, 10, 11 
            // Left
            V1, V5, V4, V0, //12, 13, 14, 15 
            // Top
            V4, V5, V6, V7, //16, 17, 18, 19 
            // Bottom 
            V0, V1, V2, V3 //20, 21, 22, 23 
        };

        newTriangles = new int[]
        {
            // Back 
            0, 1, 2,
            0, 2, 3,
            // Right 
            4, 5, 7,    //4, 5, 6,
            7, 5, 6,    //4, 6, 7, 
            // Front 
            8, 9, 11,
            11, 9, 10, 
            // Left 
            12, 13, 14,
            12, 14, 15, 
            // Top 
            16, 17, 18,
            16, 18, 19, 
            // Bottom 
            21, 20, 23,
            21, 23, 22
        };

        Vector3 Up = Vector3.up;
        Vector3 Down = Vector3.down;
        Vector3 Front = Vector3.forward;
        Vector3 Left = Vector3.left;
        Vector3 Right = Vector3.right;
        Vector3 Back = Vector3.back;

        newNormals = new Vector3[]

        {
            Back, Back, Back, Back,         // Back 
            Right, Right, Right, Right,     // Right
            Front, Front, Front, Front,     // Front
            Left, Left, Left, Left,         // Left
            Up, Up, Up, Up,                 // Top 
            Down, Down, Down, Down          // Bottom 
        };

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = new Mesh(); // Mesh 생성
        GetComponent<MeshFilter>().mesh = mesh; // MeshFilter의 mesh 값을 생성한 mesh로 초기화
        mesh.vertices = newVertices;    //// inspector에서 지정한 값을
        mesh.triangles = newTriangles;  //// vertices, triangles 로 할당
        mesh.normals = newNormals;      // normal 값 추가

        // 벡터값 다듬어서 오브젝트 최적화하는 코드 (없어도 상관 없음)
        mesh.RecalculateBounds();
        mesh.Optimize();

        Shader DefaultShader = Shader.Find("Standard");
        Material DefaultMaterial = new Material(DefaultShader);
        gameObject.GetComponent<Renderer>().material = DefaultMaterial;
    }
    void Update()
    {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3[] vertices = mesh.vertices; // vertex값 읽어서 할당
        Vector3[] normals = mesh.normals;

        for (var i = 0; i < vertices.Length; i++)
        {
            vertices[i] += normals[i] * Mathf.Sin(Time.time) * speed;// speed 값이 값이 늘어났다 줄어들었다 하는 정도를 결정
        }

        mesh.vertices = vertices;
    }
}
