using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMovement : MonoBehaviour
{
    public GameObject Sword;
    public bool canAttack = true;
    public float attackCooldown = 1.5f;
    

 
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (canAttack)
            {
                swordAttack();
            }
        } 

    }
    
    void swordAttack()
    {
        canAttack = false;
        Animator anim = Sword.GetComponent<Animator>();
        anim.SetTrigger("Attack");
        StartCoroutine(ResetAttackCooldown());
    }


    IEnumerator ResetAttackCooldown()
    {
        yield return new WaitForSeconds(attackCooldown);
        canAttack = true;
    }

       void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            
            Debug.Log("I hit something!");
        }
    }






}
