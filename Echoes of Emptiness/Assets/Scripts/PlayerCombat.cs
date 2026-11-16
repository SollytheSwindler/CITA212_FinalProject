using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject attack;
    [SerializeField] Transform catalyst;

    [SerializeField] float cooldown = 1;
    float timer;

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
        Instantiate(attack, catalyst.position, transform.rotation);
    }
}
