using UnityEngine;
using UnityEngine.SceneManagement;

public class MuerteAlColisionar : MonoBehaviour
{
    private bool muriendo = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (muriendo)
            return;

        if (collision.gameObject.CompareTag("Muerte"))
        {
            muriendo = true;

            // Reiniciar la escena actual
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}