using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject venceu;
    public GameObject falta;
    private void OnTriggerEnter2D(Collider2D other)
    {
        Personagem personagem = other.GetComponent<Personagem>();

        if(personagem != null)
        {
            if(personagem.objeto > 3 )
             {
                venceu.gameObject.SetActive(true);
                Time.timeScale = 0;
                Debug.Log("pegou");
             }
             else
              {
                falta.gameObject.SetActive(true);
                Time.timeScale = 1;
                Debug.Log("nao pegou");
              }
  
        }
    }

    public void ResumeGame()
    {
        falta.gameObject.SetActive(false);
        Time.timeScale = 1;
    }
}
