using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyHandler : MonoBehaviour
{
    public bool hasWalkAnim;
    Animator anim;

    public System.Action killed;

    Transform playerPos;
    public float enemySpeed;
    Rigidbody2D enemyRig;
    Vector2 targetDir;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyRig = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        targetDir = playerPos.position - this.transform.position;
        targetDir.y += 0.5f;
        targetDir.Normalize();
        if(hasWalkAnim)
        {
            Walk();
        }
        else
        {
            Follow();
        }
        
    }
    void Follow()
    {
        if(enemyRig.velocity.magnitude <= 5.0f) 
        {
            enemyRig.AddForce(targetDir * enemySpeed);
        }
    }

    void Walk()
    {
        anim.SetFloat("Horizontal", targetDir.x);
        anim.SetFloat("Vertical", targetDir.y);
        anim.SetFloat("magnitude", targetDir.magnitude);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene("Menu");
            
        }
    }
}
