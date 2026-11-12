using UnityEngine;

public class GerenciadorDeInimigos : MonoBehaviour
{
    public void CriarInimigo(GameObject prefab, Vector3 posicao, Quaternion rotacao)
    {
        if (prefab != null)
        {
            Instantiate(prefab, posicao, rotacao);
        }
        else
        {
            Debug.LogError("Prefab do inimigo não configurado!");
        }
    }
}
