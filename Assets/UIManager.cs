using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{

    public TextMeshProUGUI txtSaludo;
    public TMP_Inputfield inputNombre;
    string nombreUsuario;
    string saludo;


    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = string.Empty;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Saludar()
    {
        //obtener el nombre del inputfield

        nombreUsuario = inputNombre.text;

        //concatenar el nombre con el saludo

        saludo = "Hola " + nombreUsuario + "!"; 

        //mostrar el saludo en txtSaludo

        txtSaludo.text = saludo;
    }

}
