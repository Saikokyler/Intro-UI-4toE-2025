using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;


public class CLAVEMANAGER : MonoBehaviour
{
    public TMP_Inputfield inputClave;
    public TextMeshProUGUI txtMensaje;
    string clave = "tic2025"              


    // Start is called before the first frame update
    void Start()
    {
        txtMensaje.text = string.Empty;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComprobarClaveIngresada()
    {
        string claveIngresada=inputClave.text; 
        if (claveIngresada != clave)
        {
            txtMensaje.text = "acceso denegado";
        }
        else
        {
            txtMensaje.text = "bienvenido";
        }
    }

}
