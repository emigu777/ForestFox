using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _lives = 3;
    
    [SerializeField]
    private UI_Manager _uiManager;
    
    [SerializeField]
    private Animator _animator = new Animator();

    [SerializeField] 
    private Rigidbody RB;

    [SerializeField] 
    private float _speed = 5f;
    [SerializeField]
    private float _jumpingSpeed = 10f;
    
    // Start is called before the first frame update
    void Start()
    {
        _uiManager.UpdateLives(_lives);
        // START POSITION 
        transform.position = new Vector3(0f, 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    public void Damage()
    {
        // damage 
        _lives--; 
        _uiManager.UpdateLives(_lives);
        Debug.Log(" Damage -1 Lives: " + _lives);

        if (_lives == 0)
        {
            Debug.Log("Death");
        }
    }

    private void Move()
    {
        if (Input.GetKeyDown("space"))
        {
            RB.velocity += new Vector3(0f, _jumpingSpeed, 0f);
        }
        if (Input.GetKey("up"))
        {
            
            RB.MovePosition(transform.position + new Vector3(0f,0f,1f) * Time.deltaTime * _speed);
        }
        if (Input.GetKey("down"))
        {
            RB.MovePosition(transform.position + new Vector3(0f,0f,-1f) * Time.deltaTime * _speed);
        }
        if (Input.GetKey("left"))
        {
            _animator.SetBool("Run_Left", true);
            RB.MovePosition(transform.position + new Vector3(-1f,0f,0f) * Time.deltaTime * _speed);
        }
        if (Input.GetKey("right"))
        {
            RB.MovePosition(transform.position + new Vector3(1f,0f,0f) * Time.deltaTime * _speed);
        }
    }
}
