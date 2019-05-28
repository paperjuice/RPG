using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mc_behaviour : MonoBehaviour
{
    Rigidbody2D rigid;

    [SerializeField]
    float movementSpeed = 3.0f;
    [SerializeField]
    float jumpPower = 10.0f;


    // PRIVATE
    //bool canJump = false;

    private void Awake() {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Start() {
        
    }

    void Update() {
        Jump();
    }

    void FixedUpdate() {
        Movement();
    }

    void Movement() {
        float input_x = Input.GetAxisRaw("Horizontal");
        float input_y = Input.GetAxisRaw("Vertical");

        rigid.MovePosition(
            transform.position +
            transform.right *
            input_x *
            movementSpeed *
            Time.deltaTime
            );
    }

    void Jump() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rigid.AddForce(Vector2.up * jumpPower);
        }
    }
}
