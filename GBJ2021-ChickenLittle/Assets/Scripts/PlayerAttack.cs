using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public float attackCoolDownRate = 1.0f;
    private float attackisCool;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > attackisCool)
        {
            Attack();
            
        }


        void Attack()
        {


            //Test
            Debug.Log("Attacking");

            //Detect Enemies
           
            Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);

            //Deal Damage

            foreach(Collider2D enemy in hitEnemies)
            {
                enemy.GetComponent<Enemy>().TakeDamage(1);
            }

            attackisCool = Time.time + attackCoolDownRate;

        }

        
    }

    private void OnDrawGizmosSelected()
    {
        if(attackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
