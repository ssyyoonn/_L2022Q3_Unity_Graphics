using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_MeshScripting_Quad : MonoBehaviour
{
    public Vector3[] newVertices;
    public int[] newTriangles;
    // int로 선언한 이유: 삼각형 만들 때는 Vertex의 index 값을 사용

    void Start()
    {
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
