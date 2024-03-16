using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    bool isAttack = false;
    string attack = "None";
    public float speed;
    private Animator anim;
    private Rigidbody2D rig;
    float move;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        rig = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (isAttack)
        {
            if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
            {
                isAttack = false;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        if(!isAttack)
        {
            Movement();
            Attack();
        }
    }


void Movement()
{
    move = Input.GetAxis("Horizontal");
    rig.velocity = new Vector2(move * speed, 0.0f);
    anim.SetFloat("Walk", move);
}

void Attack()
{
    if(Input.GetKeyDown(KeyCode.Q))
    {
        attack = "LightPunch";
    }
    else if(Input.GetKeyDown(KeyCode.W))
    {
        attack = "HeavyPunch";
    }
    else if(Input.GetKeyDown(KeyCode.E))
    {
        attack = "LightKick";
    }
    else if(Input.GetKeyDown(KeyCode.R))
    {
        attack = "HeavyKick";
    }
    else
    {
        attack = "None";
        
    }
    if(attack != "None")
        {
            move = 0;
            rig.velocity = new Vector2(move * speed, 0.0f);
            anim.SetFloat("Walk",move);
            anim.SetTrigger(attack);
            isAttack = true;
        }
    }
}