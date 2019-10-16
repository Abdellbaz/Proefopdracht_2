using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meshTriangles : MonoBehaviour
{// Use this for initialization
    void Start()
    {
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        Vector3 center;


        center = new Vector3(0.50f, 0.50f, 0.00f);
        mesh.vertices = new Vector3[] {
        center, new Vector3(0.00f, 0.75f, 0.00f), new Vector3(0.50f, 1.00f, 0.00f),
        center, new Vector3(0.50f, 1.00f, 0.00f), new Vector3(1.00f, 0.75f, 0.00f),
        center, new Vector3(0.00f, 0.25f, 0.00f), new Vector3(0.00f, 0.75f, 0.00f),
        center, new Vector3(1.00f, 0.75f, 0.00f), new Vector3(1.00f, 0.25f, 0.00f),
        center, new Vector3(0.50f, 0.00f, 0.00f), new Vector3(0.00f, 0.25f, 0.00f),
        center, new Vector3(1.00f, 0.25f, 0.00f), new Vector3(0.50f, 0.00f, 0.00f)};

        mesh.triangles = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };

    }

   

    
}