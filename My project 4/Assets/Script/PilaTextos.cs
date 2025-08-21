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

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
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
        Debug.Log("Cima de la pila: " + cima);
        return cima;
    }

    public string PopString()
    {
        string eliminado = PilaNombres.Count > 0 ? PilaNombres.Pop() : "Pila vacía";
        eliminado1.text = "Pila:\n";
            foreach (string nombre in PilaNombres)
                {
                eliminado1.text += nombre + "\n";
            }
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
    
    public void ClearStack()
    {
    PilaNombres.Clear();
    Debug.Log("La pila fue vaciada.");
    }

    
}
