using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int hitCount = 9;

    void OnTriggerEnter2D(Collider2D collider)
    {
        hitCount = hitCount - 1;

        if (collider.name == "Bullet(Clone)")
        {
            Destroy(collider.gameObject);
        }

        if (hitCount == 0)
        {
            Destroy(gameObject);
        }
    }
}
