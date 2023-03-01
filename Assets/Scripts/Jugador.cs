using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int fuerzaDeSalto = 5;
    public bool estaSaltando;
    // Start is called before the first frame update
    void Start()
    {
        estaSaltando = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && estaSaltando == false) 
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, fuerzaDeSalto, 0);
            estaSaltando = true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstaculo"))
        {
            GameManager.Instance.ShowGameOverScreen();
        }
        
        if(collision.gameObject.tag == "Piso")
        {
            estaSaltando = false;
        }

        if(collision.gameObject.tag == "Obstaculo")
        {
            Time.timeScale = 0;
        }
    }
}
