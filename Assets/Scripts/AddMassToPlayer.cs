using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMassToPlayer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            var rb = other.GetComponent<Rigidbody2D>();

            rb.mass = 50f;

            Invoke("ResetMass", 10f);
        }
    }

    private void ResetMass()
    {
        var player = GameObject.FindGameObjectWithTag("Player");

        var rb = player.GetComponent<Rigidbody2D>();

        rb.mass = 1f;
    }
}
