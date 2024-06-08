using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyHandler : MonoBehaviour
{
    Transform playerPos;
    public float enemySpeed;
    Rigidbody2D enemyRig;
    Vector2 targetDir;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyRig = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        targetDir = playerPos.position - transform.position;
        targetDir.y += 0.5f;
        targetDir.Normalize();
        enemyRig.velocity = targetDir * enemySpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            //acho q aqui vai da para fazer o game over dai do game over leva pro menu
            SceneManager.LoadScene("Menu"); 
        }
    }
}
