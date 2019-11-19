using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private Rigidbody2D rBody;
    public float spinSpeed = 5;
    public float spinMultiplier = 1;
    // Start is called before the first frame update
    void Start()
    {
        rBody = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        rBody.angularVelocity = spinSpeed * spinMultiplier;
    }
}
