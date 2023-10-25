using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMinion : MonoBehaviour
{
    public float speed;

    public Vector3 posFinal, posInicial;


    private void Start()
    {
        posFinal = Vector2.zero;
    }
    void Update()
    {
        
        Movement();
    }

    void Movement()
    {
        Vector2 length = posFinal - transform.position;
        transform.Translate(length * speed * Time.deltaTime);
    }
}
