using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void Reiniciar()
    {
        SceneManager.LoadScene("Juego");
    }
}