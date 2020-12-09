using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeship : MonoBehaviour
{
    public float speed;
    private float translation;

    // private float moveSpeed = 3f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Ejecutamos la función propia que permite mover la nave con el joystick
        MoverNave();
    }

    void MoverNave()
    {
        /*
        //Ejemplos de Input que podemos usar más adelante
        if(Input.GetKey(KeyCode.Space))
        {
            print("Se está pulsando");
        }

        if(Input.GetButtonDown("Fire1"))
        {
            print("Se está disparando");
        }
        */
        //Variable float que obtiene el valor del eje horizontal y vertical
        float desplXleft = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.left * Time.deltaTime * desplXleft);
        float desplXright = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.left * Time.deltaTime * desplXright);

        float desplY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * Time.deltaTime * desplY);

        float translation = Input.GetAxis ("Vertical") * speed;

        translation *= Time.deltaTime;
        
        transform.Translate(0, 0, translation);

        // transform.Translate(0, 0, translation);

        //Movemos la nave mediante el método transform.translate
        //Lo multiplicamos por deltaTime, el eje y la velocidad de movimiento la nave
        // transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * desplX);
        //  transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * desplY);
    }
}
