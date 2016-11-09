using UnityEngine;
using System.Collections;

public class destruir : MonoBehaviour{


    void Start () {
     
    }

    void Update () {

    }

    void OnTriggerEnter(Collider obj)
    {
        if (obj.gameObject.tag == "destruir")
        {
            Destroy(obj.gameObject);
		
        }

    }
}