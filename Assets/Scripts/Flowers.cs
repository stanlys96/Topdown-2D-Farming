using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flowers : MonoBehaviour
{
    Animator animator;
    public float timeToDestroy = 0.3f;
    private bool destroyed = false;
    [SerializeField] GameObject rewardObject;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (timeToDestroy < 0f && !destroyed)
            {
                destroyed = true;
                if (rewardObject)
                {
                    Instantiate(rewardObject, transform.localPosition, transform.localRotation);
                }
                animator.SetTrigger("destroyed");
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timeToDestroy -= Time.deltaTime;
        }
        if (timeToDestroy < 0f && !destroyed)
        {
            destroyed = true;
            animator.SetTrigger("destroyed");
            if (rewardObject)
            {
                Instantiate(rewardObject, transform.localPosition, transform.localRotation);
            }
        }
    }
}
