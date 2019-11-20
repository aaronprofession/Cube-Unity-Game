using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMover : MonoBehaviour
{
    private Rigidbody2D rbody;
    private Transform target;

    public Transform posA;
    public Transform posB;
    public float speed = 20;

    bool A = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        target = posA;
    }

    void Update()
    {
        //Switches Target everytime a Target is Reached
        if(transform.position == target.position)
        {
            if(A == true)
            { A = false; }
            else if(A == false)
            { A = true;  }
        }
        if(A == true)
        { target = posA; }
        else if(A == false)
        { target = posB; }
    }

    //Moves Object towards current Target
    private void FixedUpdate()
    {
        float step = speed * Time.deltaTime;
        rbody.position = Vector2.MoveTowards(transform.position, target.position, step);
    }
    
}
