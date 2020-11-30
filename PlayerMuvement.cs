using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMuvement : MonoBehaviour
{
    public float speed = .5f;
    public Rigidbody2D PlayerRB;
    // esto es para conseguir el componente de un objeto en este caso el rigid budy

    void Start()
    {
        
    }

    
    void Update()
    {
        PlayerRB.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, PlayerRB.velocity.y );
        //esto es para controlar la velocidad del personaje
    }
}
