using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;

    [SerializeField] private float gravity = 9.81f;
    private CharacterController _controller;
    private Vector3 _moveDirection; 
    private bool _isJumping;
    // Start is called before the first frame update
    void Start()
    {
        CharacterController(_controller);
        GetComponent<CharacterController>();
    }
    
    void Update()
    {
        
    }
}
