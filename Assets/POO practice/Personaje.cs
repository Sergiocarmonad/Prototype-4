using UnityEngine;

public class Personaje : MonoBehaviour
{

    public string nombre;
    public float vida = 15.0f;
    public float velocidad = 55.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Presentarse();
        Moverse();
    }

    // Update is called once per frame
    void Presentarse()
    {
        Debug.Log($"mi nombre es {nombre}, tengo {vida} de vida. Necesito de tu ayuda, vamos.");
    }

    void Moverse()
    {
        Debug.Log($"*Se va corriendo a {velocidad} km por hora");
    }
}
