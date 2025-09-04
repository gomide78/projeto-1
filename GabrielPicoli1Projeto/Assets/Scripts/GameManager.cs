    using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector2 posicaoPlayerInicial;
    public int contadorDeMortes;
    public int faseAtual;
    public PlayerMovimento player;
    public UIManager  UIManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colocarPlayerPosicaoInicial();
        UIManager.AtualizarTextoFase();
        UIManager.AtualizarTextoMorte();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void colocarPlayerPosicaoInicial()
    {
        player.gameObject.transform.position = posicaoPlayerInicial;
    }


    public void ArualizarMortePlayer()
    {
        contadorDeMortes++;
        UIManager.AtualizarTextoMorte();
        colocarPlayerPosicaoInicial();
       }

}


