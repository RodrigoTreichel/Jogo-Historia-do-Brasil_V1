﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinha : MonoBehaviour
{
    public GameObject pinha;
    public GameObject historiaPinha;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Personagem")
        {
            Destroy(gameObject);

            Personagem personagem = other.GetComponent<Personagem>();

            if (personagem != null)
            {
                pinha.gameObject.SetActive(true);
                historiaPinha.gameObject.SetActive(true);
                Time.timeScale = 1;
                personagem.PegaObjeto();
            }
        }
    }

    public void ResumeGame()
    {
        historiaPinha.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}