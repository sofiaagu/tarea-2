using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI; 
using TMPro;    

public class PilaTextos : MonoBehaviour
{
    Stack <string> PilaNombres = new Stack<string>();
    public TMP_InputField Nombre;
    public TMP_Text txtPila;   
    public TMP_Text eliminado1; 

    void Start()
    {
        ActualizarVista();
    }

    void Update()
    {
        
    }
    public void PushString(){
       
       if (!string.IsNullOrEmpty(Nombre.text))
        {
            PilaNombres.Push(Nombre.text);
            txtPila.text = "Pila:\n";
            foreach (string nombre in PilaNombres)
                {
                txtPila.text += nombre + "\n";
            }
        }
        else
        {
            Debug.Log("El campo de texto está vacío.");
        }
    
    }


     public string PeekString()
    {
      string cima = PilaNombres.Count > 0 ? PilaNombres.Peek() : "Pila vacía";
         eliminado1.text = "la cima es: " + cima;
        return cima;
    }

    public string PopString()
    {
        string eliminado = PilaNombres.Count > 0 ? PilaNombres.Pop() : "Pila vacía";
        eliminado1.text = "Último eliminado: " + eliminado;
        ActualizarVista();
        return eliminado;
    }

    public void ButtonPeek()
    {
        PeekString();
    }

    public void ButtonPop()
    {
        PopString();
    }
    
    public void Clear()
    {
     PilaNombres.Clear();
        eliminado1.text = "La pila fue vaciada.";
        ActualizarVista();
    }

    private void ActualizarVista()
    {
        txtPila.text = "Pila:\n";
        foreach (string nombre in PilaNombres)
        {
            txtPila.text += nombre + "\n";
        }
    }
}
