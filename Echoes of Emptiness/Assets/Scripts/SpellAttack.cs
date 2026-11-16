using UnityEngine;

public class SpellAttack : MonoBehaviour
{
    [SerializeField] float spellAttackSpeed = 20f;
    Rigidbody2D rigidbody;
    PlayerController player;
    float xSpeed;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        player = FindAnyObjectByType<PlayerController>();
        xSpeed = -player.transform.localScale.x * spellAttackSpeed;
    }

    void Update()
    {
        rigidbody.linearVelocity = new Vector2(xSpeed, 0f);
        transform.localScale = new Vector2(-Mathf.Sign(rigidbody.linearVelocity.x), 1f);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Boss"))
        {
            Destroy(gameObject);
        }
        Destroy(gameObject);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }
}
