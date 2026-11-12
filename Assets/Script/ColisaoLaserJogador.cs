using UnityEngine;

public class ColisaoLaserJogador : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D outro)
    {
        Debug.Log("BATEU EM: " + outro.name);
        MovimentoDosInimigos inimigo =
            outro.GetComponent<MovimentoDosInimigos>();

        if (inimigo == null)
        {
            inimigo = outro.GetComponentInParent<MovimentoDosInimigos>();
        }

        if (inimigo != null)
        {
            inimigo.ReceberDano();
            Destroy(gameObject);
        }
    }
}
