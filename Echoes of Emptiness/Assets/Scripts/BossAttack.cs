using UnityEngine;

public class BossAttack : MonoBehaviour
{
    [SerializeField] GameObject player;
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
        if (player != null)
        {
            transform.position = player.transform.position;
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
