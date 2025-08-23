using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class Colas : MonoBehaviour
{
    Queue<Persona> cola = new Queue<Persona>();
    public TMP_InputField Nombre;
    public TMP_InputField Mail;
    public TMP_InputField Direccion;

    public TMP_Text txtCola; 
    public TMP_Text Cola;    

    public void Enqueue()
    {
        Persona nuevaPersona = new Persona(Nombre.text, Mail.text, Direccion.text);
        cola.Enqueue(nuevaPersona);
        MostrarCola();
        Cola.text = "Persona " + nuevaPersona;
    }

    public void StringDequeue()
    {
        if (cola.Count > 0)
        {
            Persona eliminado = cola.Dequeue();
            Cola.text = "Eliminado: " + eliminado;
            MostrarCola();
        }
        else
        {
            Cola.text = "La cola est� vac�a";
        }
    }

    public void StringPeek()
    {
        if (cola.Count > 0)
        {
            Persona primero = cola.Peek();
            Cola.text = "El primero en la cola es: " + primero;
        }
        else
        {
            Cola.text = "La cola est� vac�a";
        }
    }

    private void MostrarCola()
    {
        txtCola.text = "Cola:\n";
        foreach (Persona persona in cola) 
        {
            txtCola.text += persona.Nombre + "\n"; 
        }
    }

    public void Clear()
    {
        cola.Clear();
        Cola.text = "La pila fue vaciada.";
        MostrarCola();
    }

    public void ButtonDequeue()
    {
        StringDequeue();
    }

    public void ButtonPeek()
    {
        StringPeek();
    }


}

[System.Serializable]   
public class Persona
{
    public string Nombre;
    public string Mail;
    public string Direccion;

    public Persona(string nombre, string mail, string direccion)
    {
        Nombre = nombre;
        Mail = mail;
        Direccion = direccion;
    }

}
