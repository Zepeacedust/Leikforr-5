using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
    }
    private void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.fixedDeltaTime * speed);
        transform.Rotate(Vector3.up, horizontal);
    }
}
