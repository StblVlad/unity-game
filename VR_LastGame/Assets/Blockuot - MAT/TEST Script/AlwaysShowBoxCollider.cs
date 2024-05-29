using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class AlwaysShowBoxCollider : MonoBehaviour
{
    void OnDrawGizmos()
    {
        BoxCollider boxCollider = GetComponent<BoxCollider>();

        Gizmos.color = Color.red;
        Matrix4x4 oldMatrix = Gizmos.matrix;

        Gizmos.matrix = Matrix4x4.TRS(transform.TransformPoint(boxCollider.center), transform.rotation, transform.lossyScale);
        Gizmos.DrawWireCube(Vector3.zero, boxCollider.size);

        Gizmos.matrix = oldMatrix;
    }
}

