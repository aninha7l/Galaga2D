using UnityEngine;

public class VidaJogador : MonoBehaviour
{
    public int vidaMaxima = 20;
    public int vidaAtual;

    public BarraDeVida barraDeVida;

    void Start()
    {
        vidaAtual = vidaMaxima;

        if (barraDeVida != null)
        {
            barraDeVida.AtualizarBarra(vidaAtual, vidaMaxima);
        }
    }

    public void PerderVida()
    {
        vidaAtual--;

        if (vidaAtual < 0)
        {
            vidaAtual = 0;
        }

        Debug.Log("Vida atual: " + vidaAtual + " / " + vidaMaxima);

        if (barraDeVida != null)
        {
            barraDeVida.AtualizarBarra(vidaAtual, vidaMaxima);
        }

        if (vidaAtual <= 0)
        {
            Destroy(gameObject);
        }
    }
}
