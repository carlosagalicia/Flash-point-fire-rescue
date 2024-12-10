using UnityEngine;
using UnityEngine.UI;

public class GridElementManager : MonoBehaviour
{
    public Image[] gridElements; // Arreglo para almacenar las im�genes GridElement

    void Start()
    {
        // Inicializa el arreglo con los elementos GridElement
        gridElements = GetComponentsInChildren<Image>();
    }

    public void UpdateGridElements(int damageCount)
    {
        // Recorre las primeras 'damageCount' im�genes y cambia su color a gris
        for (int i = 0; i < damageCount && i < gridElements.Length; i++)
        {
            gridElements[i+1].color = GameConstants.grayColor;
        }
    }
}
