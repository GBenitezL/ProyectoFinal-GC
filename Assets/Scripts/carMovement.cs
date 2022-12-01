using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMovement : MonoBehaviour
{
    public float speed = 12;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "ForwardRight"){
            transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
            if (transform.position.z > 50.0f){
                transform.position = new Vector3(15, 0.5f, -50);
            }
        } else if (gameObject.tag == "ForwardLeft"){
            transform.Translate(transform.forward * speed * Time.deltaTime, Space.World);
            if (transform.position.z > 50.0f){
                transform.position = new Vector3(4.5f, 0.5f, -50);
            }
        } else if (gameObject.tag == "BackwardRight"){
            transform.Translate(-Vector3.forward * speed * 2.5f * Time.deltaTime, Space.World);
            if (transform.position.z < -50.0f){
                transform.position = new Vector3(-5.5f, 0.5f, 50);
            }
        } else if (gameObject.tag == "BackwardLeft"){
            transform.Translate(-Vector3.forward * speed * Time.deltaTime, Space.World);
            if (transform.position.z < -50.0f){
                transform.position = new Vector3(-16, 0.5f, 50);
            }
        }
    }
}
