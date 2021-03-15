using System.Collections;
using UnityEngine;

public class MeleeEnemy : rock
{
    public static bool canMove=true;

    public override void CheckDistance()
    {
        if (!canMove)
        {
            myRigidbody.velocity = Vector2.zero;
            anim.SetBool("wakeUp", false);
            return;
        }
        if (Vector3.Distance(target.position,
                                transform.position) <= chaseRadius
            && Vector3.Distance(target.position,
                                transform.position) >= attackRadius )
        {

            {
                anim.SetBool("wakeUp", true);
                Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

                changeAnim(temp - transform.position);
                myRigidbody.MovePosition(temp);

                ChangeState(EnemyState.walk);


            }

        }
        else if (Vector3.Distance(target.position, transform.position) <= chaseRadius &&
                    Vector3.Distance(target.position, transform.position) <= attackRadius)
        {
            if (currentState == EnemyState.walk && currentState != EnemyState.stagger)
            {

                StartCoroutine(AttackCo());
            }
        }
        else
        {
            anim.SetBool("wakeUp", false);
        }
        myRigidbody.velocity = Vector2.zero;



    }

    public IEnumerator AttackCo()
    {
        currentState = EnemyState.attack;
        anim.SetBool("attack", true);
        yield return new WaitForSeconds(.5f);
        currentState = EnemyState.walk;
        anim.SetBool("attack", false);


    }
}























/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : rock
{
    
    public override void CheckDistance()
    {
        if (Vector3.Distance(target.position,
                                transform.position) <= chaseRadius
            && Vector3.Distance(target.position,
                                transform.position) > attackRadius)
        {

            {
                Vector3 temp = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

                changeAnim(temp - transform.position);
                myRigidbody.MovePosition(temp);

                ChangeState(EnemyState.walk);


            }

        }
        else if(Vector3.Distance(target.position, transform.position) <= chaseRadius &&
                    Vector3.Distance(target.position, transform.position) <= attackRadius)
        {
            if (currentState == EnemyState.walk && currentState != EnemyState.stagger)
            {
                Debug.Log("attack range içinde");
              InvokeRepeating("Attackk", 2f, 3f);
                

              //  StartCoroutine(AttackCo());
            }
        }




    }

    public void Attackk()
    {
        currentState = EnemyState.attack;
        anim.SetBool("attack", true);
        Debug.Log("saldırıyor");

        currentState = EnemyState.walk;
        anim.SetBool("attack", false);
        Debug.Log("saldırı bitti");

        if (currentState == EnemyState.walk)
        {
            Debug.Log("working");

        }

        CancelInvoke("Attackk");
    }
}

*/

