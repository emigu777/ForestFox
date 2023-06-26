using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : MonoBehaviour
{
    [SerializeField]
    private Animator _animator = new Animator();

    [SerializeField] 
    private Rigidbody RB;

    [SerializeField] 
    private float _speed = 5f;
    [SerializeField]
    private float _jumpingSpeed = 10f;

    private int _score = 0; 
    
    // Start is called before the first frame update
    void Start()
    {
        // START POSITION 
        transform.position = new Vector3(0f, 0f, 20f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        
    }

    private void Move()
    {
        // jumps with space
        if (Input.GetKeyDown("space"))
        {
            RB.velocity += new Vector3(0f, _jumpingSpeed, 0f);
        }
        if (Input.GetKey("up"))
        {
            
            RB.MovePosition(transform.position + new Vector3(0f,0f,5f) * Time.deltaTime * _speed);
        }
        if (Input.GetKey("down"))
        {
            RB.MovePosition(transform.position + new Vector3(0f,0f,-5f) * Time.deltaTime * _speed);
        }
        if (Input.GetKey("left"))
        {
            RB.MovePosition(transform.position + new Vector3(-5f,0f,0f) * Time.deltaTime * _speed);
        }
        if (Input.GetKey("right"))
        {
            RB.MovePosition(transform.position + new Vector3(5f,0f,0f) * Time.deltaTime * _speed);
        }


        if (transform.position.x <= -380f)
        {
            transform.position = new Vector3(-370f, 0, transform.position.z);
        }
        if (transform.position.x >= 380f)
        {
            transform.position = new Vector3(370f, 0, transform.position.z);
        }
        if (transform.position.z <= 10f)
        {
            transform.position = new Vector3(transform.position.x, 0, 20f);
        }
        if (transform.position.z >= 800f)
        {
            transform.position = new Vector3(transform.position.x, 0, 890f);
        }
        /*
if (transform.position.y != 0)
{
    transform.position = new Vector3(transform.position.x, 0,transform.position.z);
}*/
    }

    public void ScoreUpdate()
    {
        _score += 1;
    }
}
