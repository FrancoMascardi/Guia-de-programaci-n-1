using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//7. Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y
//num3, muestre el valor del mayor de todos.
//En caso de igualdad entre los tres imprimir &quot; Los números son iguales&quot;. Test1: num1 =
//12, num2 = 4, num3= 7. Resultado esperado: El mayor número es num1 Test2: num1

//= 2, num2 = 65, num3= 8. Resultado esperado: El mayor número es num2

//Instituto de Tecnología ORT
//Carrera de Analista de Sistemas
//Materia: Taller de herramientas de programación

//Test3: num1 = 3, num2 = 10, num3= 28. Resultado esperado: El mayor número es num3
//Test4: num1 = 5, num2 = 5, num3= 5. Resultado esperado: Los números son iguales

public class Ejercicio_7 : MonoBehaviour
{
    public int num1;
        public int num2;
        public int num3;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 < 0 && num2 < 0 && num3 < 0)
        {
            Debug.Log("Ingrese un numero entero");
        }
        else
        { 
        if (num1 > num2 && num1 > num3)
        {
           
            Debug.Log("el valor mas alto es el de num1");
        }
        else if (num2 > num1 && num2 > num3)
        {
            
            Debug.Log("num2 sera el valor mas alto");
        }
        else if (num3 > num1 && num3 > num2)
        {
            
            Debug.Log("num3 sera el valor mas alto");
        }
        else if (num1 == num2 && num2 == num3)
        {
            Debug.Log("Los numeros son iguales");
        }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
