using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickables : MonoBehaviour
{
    Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (animator)
            {
                animator.SetTrigger("destroyed");
            }
        }
    }

    public void DestroyThis()
    {
        Destroy(gameObject);
    }
}
