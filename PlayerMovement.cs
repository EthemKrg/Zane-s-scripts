using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public enum PlayerState
{
    walk,
    attack,
    interact,
    stagger,
    idle
}

public class PlayerMovement : MonoBehaviour
{


    public PlayerState currentState;
    public float speed;
    private Rigidbody2D myRigidbody;
    private Vector3 change;
    private Animator animator;
    public float attackRate = 4f;
    float nextAttackTime = 4f;

    //TODO HEALTH Health sistemini burdan ayır kendine ayrı yer yap
    /*
    public FloatValue currentHealth;
    public Signal playerHealtSignal;
    */
    public VectorValue startingPosition;

    //TODO IVENTORY playerinventory sistemini burdan ayır ve ayrı yer yap
    public Inventory playerInventory;
    public SpriteRenderer receivedItemSprite;

    //TODO HEALTh player hit healt sisteminin parçası olmalı ?
    public Signal playerHit;

    // player MAGIC magic magic sisteminin parçası olmalı ?
    public Signal reduceMagic;

    //TODO IFRAME ıframe sistemini burdan ayır kendi scriptini yap
    [Header("IFrame Stuff")]
    public Color flashColor;
    public Color regularcolor;
    public float flashDuration;
    public int numberOfFlashes;
    public Collider2D triggerCollider;
    public SpriteRenderer mySprite;

    //TODO ABILITY projectile ı burdan ayır ve ability sistemi ile beraber başka yere yaz
    [Header("Projectile Stuff")]
    public GameObject projectile;
    public item staff;

   // [SerializeField] private string otherTag;




    void Start()
    {
        currentState = PlayerState.walk;
        animator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        animator.SetFloat("moveX", 0);
        animator.SetFloat("moveY", -1);
        transform.position = startingPosition.initialValue;

    }


    void Update()
    {
        myRigidbody.velocity = Vector2.zero;


        // is the player in an interaction
        if (currentState == PlayerState.interact)
        {
            return;
        }

        change.x = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        change.y = CrossPlatformInputManager.GetAxisRaw("Vertical");
        //    Input.GetAxisRaw("Vertical");




        if (Time.time >= nextAttackTime)
        {

            if (CrossPlatformInputManager.GetButtonDown("Weapon Attack") && currentState != PlayerState.attack
            && currentState != PlayerState.stagger)
            {
                SoundManager.PlaySound("swing");

                StartCoroutine(AttackCo());
                nextAttackTime = Time.time + 1f / attackRate;



            }










            //TODO  ABILITY
            else if (Input.GetButtonDown("Ability") && currentState != PlayerState.attack
            && currentState != PlayerState.stagger)
            {
                if (playerInventory.CheckForItem(staff))
                {
                    StartCoroutine(SecondAttackCo());
                }
            }
            else if (currentState == PlayerState.walk || currentState == PlayerState.idle)
            {
                UpdateAnimationAndMove();
            }


        }
    }

    //TODO ABILITY
    private IEnumerator AttackCo()
    {
        animator.SetBool("attacking", true);
        currentState = PlayerState.attack;
        new WaitForSeconds(1f);
        yield return null;
        animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.25f);
        if (currentState != PlayerState.interact)
        {
            currentState = PlayerState.walk;
        }
    }


    private IEnumerator SecondAttackCo()
    {
        //animator.SetBool("attacking", true);
        currentState = PlayerState.attack;
        yield return null;
        MakeFireBall();
        //animator.SetBool("attacking", false);
        yield return new WaitForSeconds(.25f);
        if (currentState != PlayerState.interact)
        {
            currentState = PlayerState.walk;
        }
    }

    //TODO ABILITY ability sisteminin parçası olmalı
    private void MakeFireBall()
    {
        if (playerInventory.currentMagic > 0)
        {
            Vector2 temp = new Vector2(animator.GetFloat("moveX"), animator.GetFloat("moveY"));
            FireBall fireBall = Instantiate(projectile, transform.position, Quaternion.identity).GetComponent<FireBall>();
            fireBall.Setup(temp, ChooseArrowDirection());
            playerInventory.ReduceMagic(fireBall.magicCost);
            reduceMagic.Raise();
        }
    }

    //TODO ABILITY ability sisteminin bir parçası olmalı
    Vector3 ChooseArrowDirection()
    {
        float temp = Mathf.Atan2(animator.GetFloat("moveY"), animator.GetFloat("moveX")) * Mathf.Rad2Deg;
        return new Vector3(0, 0, temp);

    }


    public void RaiseItem()
    {
        if (playerInventory.currentItem != null)
        {

            if (currentState != PlayerState.interact)
            {

                animator.SetBool("receive item", true);
                currentState = PlayerState.interact;
                receivedItemSprite.sprite = playerInventory.currentItem.itemSprite;
            }
            else
            {
                animator.SetBool("receive item", false);
                currentState = PlayerState.idle;
                receivedItemSprite.sprite = null;
            }
        }
    }

    void UpdateAnimationAndMove()
    {
        if (change != Vector3.zero)
        {
           
            MoveCharacter();
            change.x = Mathf.Round(change.x);
            change.y = Mathf.Round(change.y);
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }

    }

    void MoveCharacter()
    {
        change.Normalize();
        myRigidbody.MovePosition(
            transform.position + change * speed * Time.deltaTime);
    }

   

    //TODO KNOCKBACK kendi scripti olmalı burdan al
    /*public void Knock(float knockTime)
    {
        Debug.Log("çalıştı");
        StartCoroutine(KnockCo(knockTime));

        
        //TODO HEALTH
        currentHealth.RuntimeValue -= damage;
        playerHealtSignal.Raise();
        if (currentHealth.RuntimeValue > 0)
        {
            //TODO HEALTH
            
          
        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }

    private IEnumerator KnockCo(float knockTime)
    {
        if (myRigidbody != null)
        {
            Debug.Log("çalıştı2");
            StartCoroutine(FlashCo());
            playerHit.Raise();
            yield return new WaitForSeconds(knockTime);
            myRigidbody.velocity = Vector2.zero;
            currentState = PlayerState.idle;
            myRigidbody.velocity = Vector2.zero;
        }

    }*/






    //TODO IFRAME kendi özel scripti olmalı
    private IEnumerator FlashCo()
    {
        Debug.Log("çalıştı3");
        int temp = 0;
        triggerCollider.enabled = false;
        while(temp < numberOfFlashes)
        {
            Debug.Log("çalıştı4");
            mySprite.color = flashColor;
            yield return new WaitForSeconds(flashDuration);
            mySprite.color = regularcolor;
            yield return new WaitForSeconds(flashDuration);
            temp++;
            Debug.Log("çalıştı5");
        }
        triggerCollider.enabled = true;
        Debug.Log("çalıştı6");
    }



}




