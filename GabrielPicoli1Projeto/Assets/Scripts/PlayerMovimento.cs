using UnityEngine;
using UnityEngine.AI;

public class PlayerMovimento : MonoBehaviour
{
    public GameManager manager;
    public Rigidbody2D corpo;
    public float velocidade;
    private float inputx;
    private float inputy;
    public int ContadorDeMorte;
    public int FaseAtual;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        //codigo input
        inputx = Input.GetAxis("Horizontal");
        inputy = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        corpo.linearVelocity = new Vector2 (inputx * velocidade, inputy * velocidade);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("espinho"))  {
            manager.ArualizarMortePlayer();
        }
    }


   


}


