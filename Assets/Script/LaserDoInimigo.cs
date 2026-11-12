using UnityEngine;

public class LaserInimigo : MonoBehaviour
{
    public float velocidade = 5f;
    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.gravityScale = 0f;
        rb.linearVelocity = Vector2.left * velocidade;

        Destroy(gameObject, 3f);
    }
}
