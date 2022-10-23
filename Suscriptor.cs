using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suscriptor : MonoBehaviour
{
    public Notificador notificador;
    // Start is called before the first frame update
    void Start()
    {
        notificador.SomeEvent += MiRespuesta;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }

    void MiRespuesta() {
        Debug.Log("Soy la cápsula");
        Debug.Log(notificador.contador);
    }
}
