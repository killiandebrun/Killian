using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody rbody;
    private Renderer rend;

    // Use this for initialization
    void Start()
    {
        moveSpeed = 600f;

        rbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        rbody.AddForce(moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }

    void OnCollisionEnter(Collision col)
    {
        print(col.collider.name);
    }
}
