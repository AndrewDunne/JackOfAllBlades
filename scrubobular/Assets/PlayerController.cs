using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    CharacterController characterController;
    public Animator animator;
    public float runSpeed = 40f;

    private Vector3 moveDirection = Vector3.zero;
    float horizontalMove = 0f;
    float verticalMove = 0f;
    bool attack = false;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
    horizontalMove = Input.GetAxisRaw("Horizontal");
    verticalMove = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector3(horizontalMove, verticalMove, 0.0f);
        moveDirection *= runSpeed;
    }

    void FixedUpdate()
{
        //move our character
        characterController.Move(moveDirection * Time.deltaTime);

}
}
