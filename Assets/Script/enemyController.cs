
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour
{
    public float moveSpeed;
    public Transform leftPoint, rightPoint;
    private bool movingRight;
    private Rigidbody2D rigidB;
    public SpriteRenderer spriteR;
    private Animator animacion;
    public float moveTime, waitTime;
    private float moveCount, waitCount;

    // Start is called before the first frame update
    void Start()
    {
        rigidB = GetComponent<Rigidbody2D>();
        animacion = GetComponent<Animator>();

        leftPoint.parent = null; // para que los puntos de referencia no se muevan con el enemigo
        rightPoint.parent = null; // para que los puntos de referencia no se muevan con el enemigo

        movingRight = true;
        moveCount = moveTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (moveCount > 0)
        {
            moveCount -= Time.deltaTime;

            if (movingRight)
            {
                rigidB.velocity = new Vector2(moveSpeed, rigidB.velocity.y);
                spriteR.flipX = true;

                if (transform.position.x > rightPoint.position.x)
                {
                    movingRight = false;
                }
            }
            else
            {
                rigidB.velocity = new Vector2(-moveSpeed, rigidB.velocity.y);
                spriteR.flipX = false;

                if (transform.position.x < leftPoint.position.x)
                {
                    movingRight = true;
                }
            }

            animacion.SetBool("IsMoving", true);
        }
        else if (waitCount > 0)
        {
            waitCount -= Time.deltaTime;
            rigidB.velocity = new Vector2(0f, rigidB.velocity.y);

            if (waitCount <= 0)
            {
                moveCount = Random.Range(moveTime * .75f, moveTime * 1.25f);
            }

            animacion.SetBool("IsMoving", false);
        }
    }
}
