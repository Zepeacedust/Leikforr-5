using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10;
    private float horizontalInput;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (Input.GetButtonDown("Shoot"))
        {
            Instantiate(projectile, this.transform.position, Quaternion.identity);
        }
    }
    private void FixedUpdate()
    {
        //keeep the player in bounds
        if (transform.position.x < -10) { transform.position = new Vector3(-10, transform.position.y, transform.position.y); }
        if (transform.position.x > 10) { transform.position = new Vector3( 10, transform.position.y, transform.position.y); }
        transform.Translate(Vector3.right * speed * horizontalInput * Time.fixedDeltaTime);
    }
}
