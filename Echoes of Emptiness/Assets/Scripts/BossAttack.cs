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
        player = FindAnyObjectByType<GameObject>();
    }

    void Update()
    {
        transform.position = player.transform.position;
    }

    void Dissipate()
    {
        Destroy(gameObject);
    }
}
