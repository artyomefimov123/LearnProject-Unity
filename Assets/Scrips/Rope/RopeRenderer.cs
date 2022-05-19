using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeRenderer : MonoBehaviour
{
    public LineRenderer LineRenderer;
    public int Segments = 10;



    public void Draw(Vector3 a, Vector3 b, float length)
    {
        LineRenderer.enabled = true;
        float interpolant = Vector3.Distance(a , b) / length;
        float Offset = Mathf.Lerp(length / 2f, 0f, interpolant);
        Vector3 Adown = a + Vector3.down * Offset;
        Vector3 Bdown = b + Vector3.down * Offset;

        LineRenderer.positionCount = Segments + 1;
        for (int i = 0; i < Segments + 1; i++)
        {
            LineRenderer.SetPosition(i, Bezier.GetPoint(a,Adown, Bdown, b, (float)i / Segments));
        }
    }
    public void Hide()
    {
        LineRenderer.enabled = false;
    }
}
