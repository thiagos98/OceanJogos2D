using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMassToPlayer : MonoBehaviour
{
    private GameObject _player;
    private Rigidbody2D _rbPlayer;
    private float _initialMass;
    [SerializeField] private float _mass;
    [SerializeField] private float _duration;

    private void Start() 
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _rbPlayer = _player.GetComponent<Rigidbody2D>();
        _initialMass = _rbPlayer.mass;
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.CompareTag("Player"))
        {
            _rbPlayer.mass = _mass;

            Invoke("ResetMass", _duration);
        }
    }

    private void ResetMass()
    {
        _rbPlayer.mass = _initialMass;
    }
}
