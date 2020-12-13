﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AjtoNyitas : MonoBehaviour
{
    public GameObject Ajto;

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        PlayerMovement jatekos = FindObjectOfType<PlayerMovement>();

        if (collision.gameObject.tag == "Ajto" && jatekos.kulcsDarab == 1)
        {
            Destroy(collision.gameObject);
        }
    }
}
