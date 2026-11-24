using UnityEngine;

public class BossAttack : MonoBehaviour
{
    GameObject playerInstance;
    Rigidbody2D rigidbody;
    BossController boss;
    Animator animator;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        boss = FindAnyObjectByType<BossController>();
        animator = GetComponent<Animator>();
        playerInstance = FindAnyObjectByType<GameObject>();
    }

    void Update()
    {
        transform.position = playerInstance.transform.position;
    }

    void Dissipate()
    {
        Destroy(gameObject);
    }
}
