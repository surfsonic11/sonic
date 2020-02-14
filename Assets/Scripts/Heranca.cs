using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herança : MonoBehaviour
{
    ClasseA objetoA = new ClasseA();
    ClasseB objetoB = new ClasseB();

    private void Start()
    {
        Debug.Log("Variável id do objetoA: " + objetoA.id);
        Debug.Log("Variável id do objetoB: " + objetoB.id);

        objetoB.id = 2;

        Debug.Log("Variável id do objetoA: " + objetoA.id);
        Debug.Log("Variável id do objetoB: " + objetoB.id);
    }
}

public class ClasseA
{
    public int id;
}

public class ClasseB : ClasseA
{

}
