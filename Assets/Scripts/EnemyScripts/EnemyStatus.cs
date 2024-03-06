using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStatus : MonoBehaviour
{
    int vidaAtual;
    public int vidaTotal;

    void Start()
    {
        vidaAtual = vidaTotal;
    }
    public void ReceberDano(int valor)
    {
        vidaAtual -= valor;
        VerificarMorte();
    }
    void VerificarMorte()
    {
        if(vidaAtual == 0)
        {
            Destroy(gameObject);
        }
    }
}
