using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage_Script : MonoBehaviour
{
    void OnTriggerEnter(Collide other)
    {
        if (other.CompareTag("Ax"))
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            other.GetComponent<Player>().Damage();
            //damage player
        }
    }
     
}