using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cactus : MonoBehaviour
{
    public float tiempoVivo = 0f;
    public float tiempoMaximoDeVida = 5f;
    public float velocidad = 15f;

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(3f * (Time.deltaTime), 0, 0);
        tiempoVivo += Time.deltaTime;

        if(tiempoVivo >= tiempoMaximoDeVida)
        {
            Destroy(this.gameObject);
        }
    }
}
