using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
    public float power = 8;
    public Rigidbody rigidbody;
    public GameObject gameOverText;
    public GameObject RestartButton;
    public GameObject SkipButton;
    public GameObject ResetButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, 1) * power);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rigidbody.AddForce(new Vector3(0, 0, -1) * power);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rigidbody.AddForce(new Vector3(1, 0, 0) * power);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigidbody.AddForce(new Vector3(-1, 0, 0) * power);
        }

        if (transform.position.y < -10)
        {
            gameOverText.SetActive(true);
            RestartButton.SetActive(true);
            SkipButton.SetActive(false);
            ResetButton.SetActive(false);
        }
    }
}
