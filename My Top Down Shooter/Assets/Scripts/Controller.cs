using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Animator anim;
    public float velocity = 5;
    Vector2 movement;
    Rigidbody2D bodyRig;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        bodyRig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if(movement.x != 0 && movement.y != 0)
        {
            bodyRig.velocity = new Vector2(movement.x, movement.y) * velocity * 0.7f;
        }
        else
        {
            bodyRig.velocity = new Vector2(movement.x, movement.y) * velocity;
        }

        anim.SetFloat("Horizontal", movement.x);
        anim.SetFloat("Vertical", movement.y);
        anim.SetFloat("Magnitude", movement.magnitude);
    }

    public void SetInputVector(Vector2 inputVector)
    {
        movement.x = inputVector.x;
        movement.y = inputVector.y;
    }
}
