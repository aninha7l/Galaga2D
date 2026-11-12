using UnityEngine;

public class MovimentoDosInimigos : MonoBehaviour
{
    public float velocidade = 2f;
    public GameObject laser;
    public float intervaloTiro = 1f;

    public int vidaMaxima = 10;
    public GameObject meuPrefab;

    private int vidaAtual;
    private VidaJogador vidaJogador;

    void Start()
    {
        vidaAtual = vidaMaxima;
        Debug.Log("DANO RECEBIDO! VIDA: " + vidaAtual);
        vidaJogador = FindAnyObjectByType<VidaJogador>();

        InvokeRepeating(nameof(Atirar), 1f, intervaloTiro);
    }

    void Update()
    {
        transform.position += Vector3.left * velocidade * Time.deltaTime;

        if (transform.position.x < -10f)
        {
            if (vidaJogador != null)
            {
                vidaJogador.PerderVida();
            }

            transform.position = new Vector3(
                10f,
                transform.position.y,
                transform.position.z
            );
        }
    }

   public void ReceberDano()
{
    vidaAtual--;

    Debug.Log("VIDA DO INIMIGO: " + vidaAtual);

    if (vidaAtual <= 0)
    {
        GerenciadorDeInimigos gerenciador =
            FindAnyObjectByType<GerenciadorDeInimigos>();

        if (gerenciador != null && meuPrefab != null)
        {
            gerenciador.CriarInimigo(
                meuPrefab,
                transform.position,
                transform.rotation
            );
        }
        else
        {
            Debug.LogError("Gerenciador ou Meu Prefab não configurado!");
        }

        Destroy(gameObject);
    }
}
    void Atirar()
    {
        if (laser != null)
        {
            Instantiate(
                laser,
                transform.position,
                Quaternion.Euler(0f, 0f, 90f)
            );
        }
    }
}
