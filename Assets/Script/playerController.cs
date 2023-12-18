using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPersonaje : MonoBehaviour
{
    //header para agrupar variables en el inspector
    //variable para acceder a RigidBody
    [Header("Componentes")]
    public Rigidbody2D cuerpoRigido;

    //variable para saltar
    [Header("Salto")]
    private bool canDoubleJump;
    public float fuerzaSalto;


    //variable para velocidad
    [Header("Velocidad")] 
    public float velocidad;

    [Header("Animator")]
    private Animator animaciones;
    private SpriteRenderer sprite;

    //variable para detectar el piso y evitar doble salto
    [Header("Piso")]
    private bool isGrounded;
    public Transform pisoCheck;
    public LayerMask whatIsGround;
    
    
    // Start is called before the first frame update
    void Start()
    {
        //establecer velocidad inicial
        velocidad = 10;
        //obtener propiedades RigidBody
        cuerpoRigido = GetComponent<Rigidbody2D>();

        //obtener propiedades Animator
        animaciones = GetComponent<Animator>();

        //obtener propiedades SpriteRenderer
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per f rame
    void Update()
    {
        //agregar movimiento al personaje

        //obtener los valores de los ejes
        float movHorizontal = Input.GetAxis("Horizontal");
        float movVertical = Input.GetAxis("Vertical");

        //buscar propiedad velocity del RigidBody
        cuerpoRigido.velocity = new Vector2(movHorizontal, movVertical) * velocidad;

        isGrounded = Physics2D.OverlapCircle(pisoCheck.position, .2f, whatIsGround);

        if (isGrounded)
        {
            canDoubleJump = true;
        }

        //agregar salto al personaje
        if (Input.GetButtonDown("Jump"))
        { // si se presiona la tecla espacio, salta
            if (isGrounded)
            { 
                cuerpoRigido.velocity = new Vector2(cuerpoRigido.velocity.x, fuerzaSalto);
            
            }
            else
            {
                if(canDoubleJump)
                {
                    cuerpoRigido.velocity = new Vector2(cuerpoRigido.velocity.x, fuerzaSalto);
                    canDoubleJump = false;
                }
            }
            

        }
        // cambiar la orientacion del personaje segun la direccion del movimiento
        if (cuerpoRigido.velocity.x > 0)
        {
            sprite.flipX = true;

        } else if (cuerpoRigido.velocity.x < 0)
        {
            sprite.flipX = false;
        }



        animaciones.SetFloat("velocidad", Mathf.Abs(cuerpoRigido.velocity.x));
        animaciones.SetBool("isGrounded", isGrounded);
    }
}
