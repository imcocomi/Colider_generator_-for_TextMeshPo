
/*Colider genore*/
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TextMeshPro))]
public class TMPAutoMeshCollider : MonoBehaviour
{
    private TextMeshPro tmp;
    private MeshCollider meshCollider;

    void Awake()
    {
        tmp = GetComponent<TextMeshPro>();
        meshCollider = GetComponent<MeshCollider>();

        if (meshCollider == null)
        {
            meshCollider = gameObject.AddComponent<MeshCollider>();
            //meshCollider.convex = true;
            //meshCollider.isTrigger = true;
        }
    }

    void Start()
    {

        Invoke("UpdateColliderMesh", 0.1f); 
    }

    void UpdateColliderMesh()
    {
        if (tmp.mesh != null)
        {
            meshCollider.sharedMesh = tmp.mesh;
        }
        else
        {
            Debug.LogError("TextMeshPro mesh is not available");
        }
    }
}
