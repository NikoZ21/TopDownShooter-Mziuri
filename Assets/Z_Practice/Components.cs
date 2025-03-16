using UnityEngine;

public class Components : MonoBehaviour
{

    [SerializeField] Rigidbody2D rb;

    void Start()
    {
        Debug.Log(rb.gravityScale);
    }
}
