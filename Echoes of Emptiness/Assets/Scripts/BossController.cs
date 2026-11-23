using UnityEngine;

public class BossController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
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
        player = FindAnyObjectByType<GameObject>();
    }

    void Update()
    {
        Walk();
        FacePlayer();
        bossCombat.Attack();
    }

    void Walk()
    {
        rigidbody.linearVelocity = new Vector2(0f, moveSpeed);

        bool bossHasSpeed = Mathf.Abs(rigidbody.linearVelocity.y) > Mathf.Epsilon;
        animator.SetBool("isWalking", bossHasSpeed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        moveSpeed = -moveSpeed;
    }

    void FacePlayer()
    {
        bool playerToLeft = transform.position.x > player.transform.position.x;
        bool playerToRight = transform.position.x < player.transform.position.x;
        if (playerToLeft)
        {
            transform.localScale = new Vector2(1f, 1f);
        }
        else if (playerToRight)
        {
            transform.localScale = new Vector2(-1f, 1f);
        }
    }
}
