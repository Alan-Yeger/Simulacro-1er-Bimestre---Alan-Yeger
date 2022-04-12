using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio : MonoBehaviour
{
    public string nombreAlumno = "Ingrese su nombre";
    public int anioAlumno;
    public char orientacionAlumno;
    // Start is called before the first frame update
    void Start()
    {
        if (nombreAlumno == "" || anioAlumno < 1 || anioAlumno > 5)
        {
            Debug.Log("Error");
        }
        else if (anioAlumno < 3)
        {
            Debug.Log("Error. Aún estás en el ciclo básico");
        }
        else
        {
            switch (orientacionAlumno)
            {
                case 'T':
                Debug.Log("Muchas gracias " + nombreAlumno);
                break;
                case 'D':
                    Debug.Log("Muchas gracias " + nombreAlumno);
                    break;
                case 'G':
                    Debug.Log("Muchas gracias " + nombreAlumno);
                    break;
                case 'M':
                    Debug.Log("Muchas gracias " + nombreAlumno);
                    break;
                case 'H':
                    Debug.Log("Muchas gracias " + nombreAlumno);
                    break;
                default:
                    Debug.Log("Solo puede ingresar T, D, G, M o H");
                    break;

            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
