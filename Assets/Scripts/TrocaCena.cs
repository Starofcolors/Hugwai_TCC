using UnityEngine;
using UnityEngine.SceneManagement;

public class TrocaCena : MonoBehaviour
{
    public string MiniGame; // Nome da cena para mudar

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(MiniGame);
        }
    }

    public void Trocar()
    {
        SceneManager.LoadScene(MiniGame);
    }
    public void StartBotao()
    {
        SceneManager.LoadScene(MiniGame);
    }
}

