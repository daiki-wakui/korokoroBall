using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameManager gameManager;
    public AudioSource audioCoinSource;

    private void OnTriggerEnter(Collider other)
    {
        //‚Ô‚Â‚©‚Á‚½‘ŠŽè‚ªPlayer‚È‚ç
        if (other.gameObject.tag == "Player")
        {
          
            gameManager.AddCoinCount();
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        GameObject managerObject = GameObject.Find("GameManager");
        gameManager = managerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
