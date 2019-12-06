using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactVictory : MonoBehaviour
{
    public GameObject victoryMenu, player;
    private Component PlayerControler;
    private void Start()
    {
        PlayerControler = player.gameObject.GetComponent<PlayerControl>();
    }
    //Instansiates Victory menu upon collision
    void OnCollisionEnter2D(Collision2D other)
    {
        victoryMenu.SetActive(true);
        PlayerControler.gameObject.SetActive(false);
        CamFollow.isDead = true;
    }
}
