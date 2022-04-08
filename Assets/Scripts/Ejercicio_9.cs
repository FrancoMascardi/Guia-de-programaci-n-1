using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio_9 : MonoBehaviour
{
    public float persona_1;
    public float persona_2;
    public float persona_3;
    public string nombre_1;
    public string nombre_2;
    public string nombre_3;
    
    // Start is called before the first frame update
    void Start()
    {
        float monto;
        float porcentaje_1;
        float porcentaje_2;
        float porcentaje_3;
        monto = persona_1 + persona_2 + persona_3;
        porcentaje_1 = persona_1 * 100 / monto;
        Debug.Log("El porcentaje de lo que aporto " + nombre_1 + " es %" + porcentaje_1 + " esto serian $" + persona_1);

        porcentaje_2 = persona_2 * 100 / monto;
        Debug.Log("El porcentaje de lo que aporto " + nombre_2 + " es %" + porcentaje_2 + " esto serian $" + persona_2);

        porcentaje_3 = persona_3 * 100 / monto;
        Debug.Log("El porcentaje de lo que aporto " + nombre_3 + " es %" + porcentaje_3 + " esto serian $" + persona_3);

        Debug.Log("Entre los 3 aportaron un total de " + monto);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
