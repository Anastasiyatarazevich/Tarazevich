using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameramunu11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void firstroom()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.transform.position = new Vector3(-341.97f, 77.275f, -39.769f);
        gameObject.GetComponent<Collider>().enabled = true;
    }
}
