using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    //Variable que contendré el prefab con el obstáculo
    [SerializeField] GameObject Esferas;

    //Variables para generar columnas de forma random
    private float randomNumber;
    Vector3 RandomPos;

    //Variable que tiene la posición del objeto de referencia
    [SerializeField] Transform InitPos;

    //Acceder a los componentes de la nave
    public GameObject Nave;

    //Creamos una variable de tipo clase publica "SpaceshipMove"
    private SpaceshipMove spaceshipMove;

    // Start is called before the first frame update
    void Start()
    {
        //Accedo al script de la nave
        spaceshipMove = Nave.GetComponent<SpaceshipMove>();



        //Lanzo la corrutina
        StartCoroutine("InstanciadorEsferas");
    }

    // Update is called once per frame
    void Update()
    {
        //Poner esferas inical 20 
        for ( n = 20)
        {
            randomNumber = Random.Range(-200f, 200f);
            Vector3 RandomPos = InitPos.position + new Vector3(randomNumber, randomNumber, randomNumber);
            Instantiate(Esferas, RandomPos, Quaternion.identity);
        }
         
    }
    //crear una esfera en una cosicion random
    void Esfera()
    {
        randomNumber = Random.Range(-200f, 200f);
        RandomPos = new Vector3(randomNumber, 0, 0);
        //print(RandomPos);
        Vector3 FinalPos = InitPos.position + RandomPos;
        Instantiate(Esferas, FinalPos, Quaternion.identity);

    }

    

    //colocar las esferas en una posicion random
    IEnumerator InstanciadorColumnas()
    {
        //Bucle infinito 
        for (; ; )
        {
            Esfera();
            float interval = 4 / spaceshipMove.speed;
            yield return new WaitForSeconds(interval);
        }
