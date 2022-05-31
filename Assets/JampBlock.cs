using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JampBlock : MonoBehaviour
{
    public AudioSource audioSource;
    public float power = 8;
    public Vector3 jumpAngle = new Vector3(0, 1, 1);

    private void OnTriggerEnter(Collider other)
    {
        Rigidbody otherRigidbody = other.GetComponent<Rigidbody>();
        if (otherRigidbody != null)
        {
            audioSource.Play();
            otherRigidbody.velocity = jumpAngle.normalized * power;
        }
    }
}
