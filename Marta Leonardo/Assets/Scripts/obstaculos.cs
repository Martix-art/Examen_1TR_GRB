using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstaculos : MonoBehaviour
{
    [SerializeField] GameObject Esferas;

    private float randomNumber;

    [SerializeField] Transform InitPos;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Distancia inical 20 esferas
        
        
            randomNumber = Random.Range(-200f, 200f);
            Vector3 RandomPos = InitPos.position + new Vector3(randomNumber, randomNumber, randomNumber);
            Instantiate(Esferas, RandomPos, Quaternion.identity);

        
    }
   
    
}
