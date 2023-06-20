using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomBehavior : MonoBehaviour
{
    [SerializeField] 
    private Player _player;

    //If Player collects the mushroom, the score goes up.
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _player.ScoreUpdate();
            Destroy(this.gameObject);
        }
    }
}
