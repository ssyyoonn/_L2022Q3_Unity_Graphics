using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_MeshScripting_GetMeshProperties : MonoBehaviour
{
    Mesh mesh;
    void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;
        print(mesh.name);
        print(mesh.vertices);
        int counter = 0;
        foreach(Vector3 vextex in mesh.vertices)
        {
            print(counter + ", " + vextex);
           counter++;
        }

    }
}
