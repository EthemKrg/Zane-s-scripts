using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerKnockback : MonoBehaviour
{
    [SerializeField] public float thrust;
    [SerializeField] public float knockTime;
    [SerializeField] public string otherTag;
    [SerializeField] public float damage;
    public GameObject blood;
    private float destroybloodtime = 60f;

    public FloatValue demic;

    private void LateUpdate()
    {
        damage = demic.RuntimeValue;
    }



    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag(otherTag) && other.isTrigger)
        {
            Rigidbody2D hit = other.GetComponentInParent<Rigidbody2D>();
            if (hit != null)
            {
                if (blood == true)
                {
                    SoundManager.PlaySound("cut");
                    GameObject Blood = Instantiate(blood, transform.position, Quaternion.Euler(Random.Range(0.0f, 40.0f),
                        Random.Range(0.0f, 40.0f), Random.Range(0.0f, 360.0f)));
                    Destroy(Blood, destroybloodtime);
                }
                Vector3 difference = hit.transform.position - transform.position;
                difference = difference.normalized * thrust;
                hit.DOMove(hit.transform.position + difference, knockTime);
              //   hit.AddForce(difference, ForceMode2D.Impulse);

                if (other.gameObject.CompareTag("enemy") && other.isTrigger)
                {

                    hit.GetComponent<Enemy>().currentState = EnemyState.stagger;
                    other.GetComponent<Enemy>().Knock(hit, knockTime);
                    other.GetComponent<Enemy>().TakeDamage(damage);

                }








            }
        }



    }




}