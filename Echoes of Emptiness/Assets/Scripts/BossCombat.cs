using UnityEngine;

public class BossCombat : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject attack;
    [SerializeField] Transform playerTransform;

    [SerializeField] float cooldown = 5f;
    float timer;

    void Start()
    {
        timer = cooldown;
    }

    void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
    }

    public void Attack()
    {
        if (timer <= 0)
        {
            animator.SetBool("isAttacking", true);
            timer = cooldown;
        }
    }

    public void FinishAttacking()
    {
        animator.SetBool("isAttacking", false);
        Instantiate(attack, playerTransform.position, transform.rotation);
    }
}
