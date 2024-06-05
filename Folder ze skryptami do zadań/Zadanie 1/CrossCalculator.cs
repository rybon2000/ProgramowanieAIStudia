using UnityEngine;
public class CrossCalculator : MonoBehaviour
{
    void Start()
    {
        Vector3 v = new Vector3(1f, 2f, 3f);
        Vector3 w = new Vector3(4f, 5f, 6f);
        Vector3 result = CrossProduct(v, w);
        Debug.Log("Result Ratio Vector: " + result);
    }

    public Vector3 CrossProduct(Vector3 v, Vector3 w)
    {
        float x = v.y * w.z - v.z * w.y;
        float y = v.z * w.x - v.x * w.z;
        float z = v.x * w.y - v.y * w.x;

        return new Vector3(x, y, z);
    }
}
