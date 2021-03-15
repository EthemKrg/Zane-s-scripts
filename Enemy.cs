using System.Collections;
using UnityEngine;

public enum EnemyState
{
    idle,
    walk,
    attack,
    stagger,
    dead

}
public class Enemy : MonoBehaviour {

    [Header("State Machine")]
    public EnemyState currentState;
    public bool enemy_dead;
    public BoolValue enemy_dead_value;


    [Header("Enemy Stats")]
    public FloatValue maxHealth;
    public float health;
    public string enemyName;
    public int baseAttack;
    public float moveSpeed;
    public Vector2 homePosition;

    [Header("Death Effects")]
    public GameObject deathEffect;
    private float deathEffectDelay = 1f;
    private float destroybodytime = 60f;
    public LootTable thisLoot;

    [Header("Death Signals")]
    public Signal roomSignal;

    public GameObject deadbody;




    private void Awake()
    {
        enemy_dead = enemy_dead_value.RuntimeValue;
        if (enemy_dead == true)
            this.gameObject.SetActive(false);

        health = maxHealth.RuntimeValue;

 

    }

    private void OnEnable()
    {
        transform.position = homePosition;
        health = maxHealth.RuntimeValue;
        currentState = EnemyState.idle;
    }

    public void TakeDamage(float damage)
    {

        health -= damage;
        if(health <= 0)
        {
            SoundManager.PlaySound("die");
            DeathEffect();

            this.gameObject.SetActive(false);
            enemy_dead = true;
            enemy_dead_value.RuntimeValue = enemy_dead;

            MakeLoot();
            if(roomSignal != null)
            {
                roomSignal.Raise();
            }
          
          
        }
    }

  




    private void MakeLoot()
    {
        if(thisLoot != null)
        {
            PowerUp current = thisLoot.LootsPowerUp();
            if(current != null)
            {
                Instantiate(current.gameObject, transform.position, Quaternion.identity);
                GameObject Deadbody = Instantiate(deadbody, transform.position, Quaternion.identity);
                Destroy(Deadbody, destroybodytime);
            }
        }
    }





    private void DeathEffect()
    {
        if(deathEffect != null)
        {
            SoundManager.PlaySound("die");
            GameObject effect = Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(effect, deathEffectDelay); 
        }


    }




    public void Knock(Rigidbody2D myRigidbody, float knockTime)
    {
       
        StartCoroutine(KnockCo(myRigidbody, knockTime));
        
    }

    private IEnumerator KnockCo(Rigidbody2D myRigidbody, float knockTime)
    {
        if (myRigidbody != null)
        {
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = EnemyState.idle;
            myRigidbody.velocity = Vector2.zero;
            
        }
    }
}
