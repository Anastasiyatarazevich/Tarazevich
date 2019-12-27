using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation1 : MonoBehaviour
{
    private
     void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Plane")
        {
            gameObject.transform.rotation = Quaternion.Euler(-90, 0, 0);
            //   gameObject.transform.position = new Vector3(6.73f, 0.74f, 4.44f);
        }
    }
}

