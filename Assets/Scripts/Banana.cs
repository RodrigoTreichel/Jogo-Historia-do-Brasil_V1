﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : MonoBehaviour
{
    public GameObject banana;
    public GameObject historiaBanana;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Personagem")
        {
            Destroy(gameObject);

            Personagem personagem = other.GetComponent<Personagem>();

            if (personagem != null)
            {
                banana.gameObject.SetActive(true);
                historiaBanana.gameObject.SetActive(true);
                Time.timeScale = 1;
                personagem.PegaObjeto();
            }
        }
    }

    public void ResumeGame()
    {
        historiaBanana.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}