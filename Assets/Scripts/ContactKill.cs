using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactKill : MonoBehaviour
{
    public GameObject DeathText;
    
    //Destroys touching object by contact
    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(other.gameObject);
        DeathText.gameObject.SetActive(true);
        CamFollow.isDead = true;
    }
}
