using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMuvement : MonoBehaviour
{
    // serializefield hace que la variable sea visible en eleditor pero es privada
    [SerializeField] private float JumpSpeed = 300;
    [SerializeField] private float speed = 4;
    [SerializeField] private Rigidbody2D PlayerRB;
    // esto es para conseguir el componente de un objeto en este caso el rigid budy

    void Start()
    {
        
    }

    
    void Update()
    {
        PlayerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, PlayerRB.velocity.y );
        //esto es para controlar la velocidad del personaje el get axis es el mapeo de las teclas 

        if (Input.GetKeyDown(KeyCode.Space))
        // key code es para buscar el mapeo de las teclas y agregar un salto a mi personaje
        {
            PlayerRB.AddForce(Vector2.up * JumpSpeed);


        }
    }
}
