using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //PONTUAR - SUBTRAIR VIDA - CHECAR STATO DE GAME , TEMPO DE GAME
    public MinionsInstantiate minionsInstantiate;
    public MovementMinion movementMinion;


    private void Update()
    {
        CicleOfLife();
    }


    void CicleOfLife() //checar estado de game para ficar mais dificil
    {
        if (minionsInstantiate.contador > 10)   movementMinion.speed = 0.7f;
        else if (minionsInstantiate.contador > 20) movementMinion.speed = 0.8f;
        else if (minionsInstantiate.contador > 30) movementMinion.speed = 0.9f;
        else if (minionsInstantiate.contador > 60) movementMinion.speed = 1.3f;
        else if (minionsInstantiate.contador > 90) movementMinion.speed = 1.6f;
        else if (minionsInstantiate.contador > 120) movementMinion.speed = 2f;
    }
}
