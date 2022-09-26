using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private Renderer rd;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Столкновение началось");
        SetColor(Color.green);
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Столкновение закончилось");
        SetColor(Color.red);
    }

    private void SetColor(Color color)
    {
        rd.material.SetColor("_Color", color);
    }
}
