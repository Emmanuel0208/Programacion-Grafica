using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class UVMapping : MonoBehaviour
{
    public Material material;
    void Start()
    {
        
        Vector3[] vertices = {
                           new Vector3(0, 0, 0),//0 a
                           new Vector3(1, 0, 0),//1 b
                           new Vector3(0.5f, 0, 0.87f),//2 c
                           new Vector3(0.5f, 0.82f, 0.29f),//3 d
                           new Vector3(0.5f, 0.82f, 0.29f),//3 d
                           new Vector3(0.5f, 0.82f, 0.29f)//3 d
            
        };

        int[] triangles = {
            0, 2, 1, // front
			1, 2, 3,
            4, 5, 6, // back
			5, 7, 6,
            6, 7, 8, //top
			7, 9 ,8,
            1, 3, 4, //bottom
			3, 5, 4,
            1, 11,10,// left
			1, 4, 11,
            3, 12, 5,//right
			5, 12, 13


        };


        Vector2[] uvs = {
            new Vector2(0, 0.66f),
            new Vector2(0.25f, 0.66f),
            new Vector2(0, 0.33f),
            new Vector2(0.25f, 0.33f),

            new Vector2(0.5f, 0.66f),
            new Vector2(0.5f, 0.33f),
            new Vector2(0.75f, 0.66f),
            new Vector2(0.75f, 0.33f),

            new Vector2(1, 0.66f),
            new Vector2(1, 0.33f),

            new Vector2(0.25f, 1),
            new Vector2(0.5f, 1),

            new Vector2(0.25f, 0),
            new Vector2(0.5f, 0),
        };

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.uv = uvs;
        mesh.Optimize();
        mesh.RecalculateNormals();
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material = material;
    }
}