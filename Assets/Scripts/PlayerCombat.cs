using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerCombat : MonoBehaviour
{

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 40;

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log("right clicked");
            Attack();

        }
    }

    void Attack()
    {
        // Play an attack animation


        // Detect enemies in attack range
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange,enemyLayers);
        
        // Damage enemies in range
        foreach(Collider2D enemy in hitEnemies)
    {
        enemy.GetComponent<Enemy>().IamHurt(attackDamage);
    }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }   
}
