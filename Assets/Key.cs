using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject doorObject;
    private void OnTriggerEnter(Collider other)
    {
        //‚Ô‚Â‚©‚Á‚½‘ŠŽè‚ªPlayer‚È‚ç
        if (other.gameObject.tag == "Player")
        {
            Destroy(doorObject);
            Destroy(gameObject);
        }
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
