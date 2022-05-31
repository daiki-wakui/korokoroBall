using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelFiled : MonoBehaviour
{
    public float power = 300;

    private void OnTriggerStay(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(1, 0, 0) * power);
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
