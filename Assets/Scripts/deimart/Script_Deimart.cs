using UnityEngine;
using System.Collections;

public class Script_Deimart : MonoBehaviour {
    bool ban;
    public Rigidbody z;

    void Start()
    {
        ban = false;
        z = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (ban == false)
        {
            mover();
        }
        
       
        
    }

    void mover()
    {
        transform.Translate(0.15f * Time.deltaTime, 0f, 0f);
    }

     void OnTriggerEnter(Collider obj)
     {
         if (obj.gameObject.tag == "freno")
         {

             ban = true;
          
        }

     }
    }

