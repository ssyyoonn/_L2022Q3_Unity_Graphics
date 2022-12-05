using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_MeshScripting_Pyramid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 V0, V1, V2, V3, V4;
        Vector3[] newVertices;
        int[] newTriangles;

        V0 = new Vector3(-0.5f, 0, -0.5f);
        V1 = new Vector3(-0.5f, 0, 0.5f);
        V2 = new Vector3(0.5f, 0, 0.5f);
        V3 = new Vector3(0.5f, 0, -0.5f);
        V4 = new Vector3(0, 1, 0);

        newVertices = new Vector3[]
        {
            V0, V1, V2, V3, V4
        };

        newTriangles = new int[]
        {
            0, 2, 1,    // 밑 (방향 주의                                 )
            0, 3, 2,    // 면 (=> 밑바닥에서 보여야 하므로 시계 반대 방향)
            0, 4, 3,    // 앞면
            3, 4, 2,    // 오른쪽
            2, 4, 1,    // 뒷면
            1, 4, 0     // 왼쪽
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
