using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
public class AlwaysShowMeshCollider : MonoBehaviour
{
    void OnDrawGizmos()
    {
        MeshCollider meshCollider = GetComponent<MeshCollider>();

        if (meshCollider.sharedMesh == null)
            return;

        Gizmos.color = Color.red;
        Matrix4x4 oldMatrix = Gizmos.matrix;

        Gizmos.matrix = transform.localToWorldMatrix;
        Gizmos.DrawWireMesh(meshCollider.sharedMesh);

        Gizmos.matrix = oldMatrix;
    }
}
