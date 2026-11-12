using UnityEngine;

public class BarraDeVida : MonoBehaviour
{
    private float larguraMaxima;
    private float posicaoInicialX;

    void Awake()
    {
        larguraMaxima = transform.localScale.x;
        posicaoInicialX = transform.localPosition.x;
    }

    public void AtualizarBarra(int vidaAtual, int vidaMaxima)
    {
        float porcentagem = (float)vidaAtual / vidaMaxima;

        transform.localScale = new Vector3(
            larguraMaxima * porcentagem,
            transform.localScale.y,
            transform.localScale.z
        );

        transform.localPosition = new Vector3(
            posicaoInicialX - (larguraMaxima * (1 - porcentagem) / 2),
            transform.localPosition.y,
            transform.localPosition.z
        );
    }
}
