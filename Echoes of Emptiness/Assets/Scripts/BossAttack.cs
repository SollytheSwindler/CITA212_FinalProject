using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Rigidbody2D rigidbody;
    BossController boss;
    Animator animator;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boss = FindAnyObjectByType<BossController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (playerTransform != null)
        {
            transform.position = playerTransform.position;
        }
        else
        {
            Dissipate();
        }
    }

    void Dissipate()
    {
        Destroy(gameObject);
    }
}
