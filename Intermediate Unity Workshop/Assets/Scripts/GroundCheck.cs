using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    private Movement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerMovement = gameObject.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            playerMovement.SetCanJump(true);
        }
    }
}
