
using UnityEngine;

public class TurretEnemy : rock {

    public GameObject projectile;
    public float fireDelay;
    private float fireDelaySeconds;
    public bool canFire = true;

    public static bool canMove = true;


    private void Update()
    {
        fireDelaySeconds -= Time.deltaTime;
        if(fireDelaySeconds <= 0)
        {
            canFire = true;
            fireDelaySeconds = fireDelay;
        }
    }
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
                              transform.position) > attackRadius)
        {
            if (currentState == EnemyState.idle || currentState == EnemyState.walk
               && currentState != EnemyState.stagger)
            {

                if (canFire)
                {
                    Vector3 tempVector = target.transform.position - transform.position;
                    GameObject current = Instantiate(projectile, transform.position, Quaternion.identity);
                    current.GetComponent<Projectile>().Launch(tempVector);
                    canFire = false;
                    ChangeState(EnemyState.walk);
                    anim.SetBool("wakeUp", true);
                }

            }

        }
        else if (Vector3.Distance(target.position,
                                transform.position) > chaseRadius)
        {
            anim.SetBool("wakeUp", false);
        }
    }
}
