using UnityEngine;

public class ColisaoLaserInimigo : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D outro)
    {
        if (outro.CompareTag("Player"))
        {
            VidaJogador vida = outro.GetComponent<VidaJogador>();

            if (vida != null)
            {
                vida.PerderVida();
            }

            Destroy(gameObject);
        }
    }
}
