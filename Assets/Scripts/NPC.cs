using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Dialogue.instance.gameObject.SetActive(true);
            Dialogue.instance.NPCTalk("Greetings warrior!");
        }
    }
}
