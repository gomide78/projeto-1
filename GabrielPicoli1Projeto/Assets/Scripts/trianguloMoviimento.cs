using UnityEngine;
using UnityEngine.Windows;

public class trianguloMoviimento : MonoBehaviour
{
    public Rigidbody2D meioQuadrado;
    public float velocidade;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        meioQuadrado.linearVelocity = new Vector2(velocidade, velocidade);
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if (collision.gameObject.CompareTag("parede")) {
            velocidade *= -1;
        }
    }
    



}



