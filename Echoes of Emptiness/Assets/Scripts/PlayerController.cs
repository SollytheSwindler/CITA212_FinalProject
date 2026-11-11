using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] GameObject attack;
    [SerializeField] Transform catalyst;

    Vector2 moveInput;
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

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
        Debug.Log(moveInput);
    }

    void Walk()
    {
        Vector2 playerVelocity = new Vector2(moveInput.x * moveSpeed, moveInput.y * moveSpeed);
        rigidbody.linearVelocity = playerVelocity;

        bool playerHasSpeed = Mathf.Abs(rigidbody.linearVelocity.x) > Mathf.Epsilon
            || Mathf.Abs(rigidbody.linearVelocity.y) > Mathf.Epsilon;
        animator.SetBool("isWalking", playerHasSpeed);
    }

    void FlipSprite()
    {
        bool hasHorizontalSpeed = Mathf.Abs(rigidbody.linearVelocity.x) > Mathf.Epsilon;
        if (hasHorizontalSpeed)
        {
            transform.localScale = new Vector2(-Mathf.Sign(rigidbody.linearVelocity.x), 1f);
        }
    }
}
