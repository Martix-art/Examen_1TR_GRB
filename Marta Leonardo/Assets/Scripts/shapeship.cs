using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Importante importar esta librería para usar la UI

public class shapeship : MonoBehaviour
{
    public float speed;
    private float translation;
    private Vector3 moveSpeed;

    //Variable que determina cómo de rápido se mueve la nave con el joystick
    private float moveSpeed = 3f;

    //Capturo el texto del UI que indicará la distancia recorrida
    [SerializeField] Text TextDistance;

    //Variable para parar el juego
    [SerializeField] MeshRenderer myMesh;
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

    //codigo para la colision
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "obstacle")
        {
            //desaparece la maya
            myMesh.enabled = false;
            //la velocidad se para
            speed = 0f;
            //la corutine se para
            StopCoroutine("Distancia");
        }

    }

    //Corrutina que hace cambiar el texto de tiempo transcurrido
    IEnumerator Distancia()
    {
        //Bucle infinito que suma 10 en cada ciclo
        //El segundo parámetro está vacío, por eso es infinito
        for (int n = 0; ; n += 1)
        {
            //Cambio el texto que aparece en pantalla
            TextDistance.text = "DISTANCIA: " + n * speed;

            //cada ciclo aumenta la velocidad
            if (speed < 26)
            {
                speed = speed + 0.3f;
            }

            //Ejecuto cada ciclo esperando 1 segundo
            yield return new WaitForSeconds(0.25f);
        }

    }
    void MoverNave()
    {
        
        //Variable float que obtiene el valor del eje horizontal y vertical
        float desplX = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Vector3.right * Time.deltaTime * desplX);
       

        float desplY = Input.GetAxis("Vertical") * speed;
        transform.Translate(Vector3.up * Time.deltaTime * desplY);

      
        //Movemos la nave mediante el método transform.translate
        //Lo multiplicamos por deltaTime, el eje y la velocidad de movimiento la nave
        transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * desplX);
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed * desplY);
    }
}
