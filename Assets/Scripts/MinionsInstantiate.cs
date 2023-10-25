using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MinionsInstantiate : MonoBehaviour
{
    public GameObject[] prefabBallMinion;
    public Transform[] posicoes;
    public int contador, delay = 3;
    private void Update()
    {
        TimeToRespaw();
    }
    void Instanciar()
    {

        Instantiate(prefabBallMinion[Random.Range(0, prefabBallMinion.Length)], posicoes[Random.Range(0, posicoes.Length)].position, Quaternion.identity);
    }

    void TimeToRespaw()
    {

        if (contador > delay)
        {
            delay += 5;
            Instanciar();

        }

        contador = (int)Time.time;
    }
}
