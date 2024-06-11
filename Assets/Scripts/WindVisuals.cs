using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]

public class WindVisuals : MonoBehaviour
{
    public Vector3 windDirection = new Vector3(1, 0, 0);
    public float windStrength = 5.0f;
    public Color gizmoColor = Color.cyan;
    public float arrowHeadLength = 0.25f;
    public float arrowHeadAngle = 20.0f;

    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;

        Vector3 startPosition = transform.position;
        Vector3 endPosition = startPosition + windDirection.normalized * windStrength;

        Gizmos.DrawLine(startPosition, endPosition);
        DrawArrowEnd(endPosition);
    }

    void DrawArrowEnd(Vector3 position)
    {
        Vector3 direction = windDirection.normalized;
        Vector3 right = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 + arrowHeadAngle, 0) * new Vector3(0, 0, 1);
        Vector3 left = Quaternion.LookRotation(direction) * Quaternion.Euler(0, 180 - arrowHeadAngle, 0) * new Vector3(0, 0, 1);

        Gizmos.DrawLine(position, position + right * arrowHeadLength);
        Gizmos.DrawLine(position, position + left * arrowHeadLength);
    }
}
