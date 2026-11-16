using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject attack;
    [SerializeField] Transform catalyst;

    public void Attack()
    {
        animator.SetBool("isAttacking", true);
    }

    public void FinishAttacking()
    {
        animator.SetBool("isAttacking", false);
        Instantiate(attack, catalyst.position, transform.rotation);
    }
}
