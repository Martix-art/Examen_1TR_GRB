using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    [SerializeField] Transform Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Estas líneas de código hacen que la cámara siga al objeyivo
        transform.position = new Vector3(Target.position.x + 74.9f, Target.position.y + 17.2f, Target.position.z + 0.3f);
    }
}
