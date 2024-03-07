using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int vidaAtual;
    public int vidaTotal;
    public GameObject HitImagem;

    void Start()
    {
        vidaAtual = vidaTotal;
    }
    public void ReceberDano(int valor)
    {
        vidaAtual -= valor;
        VerificarMorte();
        HitImagem.SetActive(true);
        Invoke("DesabilitarHitImagem", 0.5f);
    }
    void VerificarMorte()
    {
        if(vidaAtual == 0)
        {
            Destroy(gameObject);
        }
    }
    void DesabilitarHitImagem() 
    {
        HitImagem.SetActive(false);
    }
}
