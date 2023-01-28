using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float jumpHeight;

    private bool canJump;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        this.transform.position += new Vector3(x * Time.deltaTime * moveSpeed, 0, 0);

        if (Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.velocity += new Vector2(0, jumpHeight);
            canJump = false;
        }
    }

    public void SetCanJump(bool value)
    {
        canJump = value;
    }
}
