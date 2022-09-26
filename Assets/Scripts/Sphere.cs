using UnityEngine;

public class Sphere : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    private void OnEnable()
    {
        rb.AddForce(new Vector3(0, 0, -1000));
    }
}
