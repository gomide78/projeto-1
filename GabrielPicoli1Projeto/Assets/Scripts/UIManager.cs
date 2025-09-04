using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameManager manager;
    public TMP_Text textoFase;
    public TMP_Text textoMorte;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AtualizarTextoFase() {
        textoFase.text = manager.faseAtual + "/7";
    }

    public void AtualizarTextoMorte() {
        textoMorte.text = "mortes: " + manager.contadorDeMortes;
    }

    public void VoltarMenu() {
        SceneManager.LoadScene(0);
    }



}



