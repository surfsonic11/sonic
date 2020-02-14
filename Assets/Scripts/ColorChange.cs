using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    float randomColor;
    Renderer rendererer;

    private void Awake()
    {
        rendererer = GetComponent<Renderer>();
        randomColor = Random.Range(1, 7);

        switch (randomColor)
        {
            case 1:
                rendererer.material.color = Color.yellow;
                break;
            case 2:
                rendererer.material.color = Color.green;
                break;
            case 3:
                rendererer.material.color = Color.magenta;
                break;
            case 4:
                rendererer.material.color = Color.red;
                break;
            case 5:
                rendererer.material.color = Color.blue;
                break;
            case 6:
                rendererer.material.color = Color.cyan;
                break;

        }
    }
}
