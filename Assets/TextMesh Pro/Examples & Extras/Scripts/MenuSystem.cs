using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuSystem : MonoBehaviour
{
    [Tooltip("Nombre de la escena a cargar. Poner 'cubo' para cargar la escena cubo.")]
    public string escenaDestino = "cubo";

    public void Jugar()
    {
        Debug.Log($"Cargando escena: {escenaDestino}");
        SceneManager.LoadScene(escenaDestino);
    }

    // Permite cargar directamente una escena pasando su nombre (útil para UnityEvents con parámetro)
    public void JugarEscena(string nombreEscena)
    {
        if (string.IsNullOrEmpty(nombreEscena)) nombreEscena = escenaDestino;
        Debug.Log($"Cargando escena: {nombreEscena}");
        SceneManager.LoadScene(nombreEscena);
    }

    // Permite cambiar el destino desde UI o código
    public void SetEscenaDestino(string nombre)
    {
        escenaDestino = nombre;
    }

    public void Salir()
    {
        Debug.Log("Saliendo del juego");
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
