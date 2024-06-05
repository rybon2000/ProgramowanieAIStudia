using UnityEngine;

public class DotCalculator : MonoBehaviour
{
    private void Start()
    {
        Vector2 v = new Vector2(3f, 4f);
        Vector2 w = new Vector2(5f, 6f);
        float result = DotProduct(v, w);
        Debug.Log("Dot Calc: " + result);
    }

    public float DotProduct(Vector2 v, Vector2 w)
    {
        float dotProduct = v.x * w.x + v.y * w.y;
        return dotProduct;
    }
}
