using UnityEngine;

public class BossController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] BossCombat bossCombat;
    [SerializeField] GameObject player;

    Rigidbody2D rigidbody;
    CapsuleCollider2D capsuleCollider;
    Animator animator;
    SpriteRenderer spriteRenderer;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        capsuleCollider = GetComponent<CapsuleCollider2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Walk();
        FlipSprite();
    }

    void Walk()
    {
        Vector2 bossVelocity = new Vector2(0f, Random.Range(-1, 1) * moveSpeed);
        rigidbody.linearVelocity = bossVelocity;

        bool bossHasSpeed = Mathf.Abs(rigidbody.linearVelocity.x) > Mathf.Epsilon
            || Mathf.Abs(rigidbody.linearVelocity.y) > Mathf.Epsilon;
        animator.SetBool("isWalking", bossHasSpeed);
    }

    void FlipSprite()
    {
        bool isFacingPlayer = transform.position.x > player.transform.position.x;
        if (!isFacingPlayer)
        {
            transform.localScale = new Vector2(-Mathf.Sign(rigidbody.linearVelocity.x), 1f);
        }
    }
}
