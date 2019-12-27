using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter(Collision collision)
    {
        if((collision.collider.name == "Floor1") || (collision.collider.name == "Floor"))
        {
            gameObject.transform.rotation = Quaternion.identity;
        }
    }
}
