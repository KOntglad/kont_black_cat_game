using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_main : MonoBehaviour
{
    public float speed;
    public SphereCollider ball_collider;
    RaycastHit ball_hit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = transform.position + transform.forward * speed * Time.fixedDeltaTime;
        if(Physics.SphereCast(transform.position,ball_collider.radius,transform.forward,out ball_hit)) 
        {
            if(ball_hit.collider.gameObject.layer == 9) 
            {
                Destroy(gameObject);
            }   
        }
    }
}
