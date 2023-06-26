using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom_Behavior : MonoBehaviour
{
    [SerializeField] 
    private Player_Script _playerScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _playerScript.ScoreUpdate();
            Destroy(this.gameObject);
        }
    }
}
