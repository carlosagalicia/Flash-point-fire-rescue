using UnityEngine;

public class GameConstants : MonoBehaviour
{
    // Variables globales
    public static int damageCounter = 0; // Contador de da�o actual
    public static int maxDamage = 24; // Da�o m�ximo tolerable
    public static int maxHealth = 4; // Salud maxima de las puertas
    public static int explosionDamage = 2; // Da�o por explosi�n
    public static int rows = 6; // N�mero de filas
    public static int cols = 8; // N�mero de columnas
    public static float cellWidth = 10f; // Ancho de cada celda
    public static float cellHeight = 10f; // Altura de cada celda
    public static float wallThickness = 0.5f; // Altura de cada celda
    public static float minuteToRealTime = 1f; // Proporcion minuto del juego vs minuto real
    public static Color grayColor = new Color(0.3f, 0.3f, 0.3f, 1f); // Color gris
    public static Color whiteColor = new Color(1f, 1f, 1f, 1f); // Color blanco
    public static Color redColor = new Color(.7f, 0f, 0f, 1f); // Color blanco
    public static float rotationSpeed = 500.0f; // Velocidad de rotacion horizontal de la camara
    public static float zoomScale = 10.0f; // Velocidad de zoom de la camara
    public static float zoomMin = 10f; // Limite minimo de zoom
    public static float zoomMax = 35.0f; // Limite maximo de zoom
    public static Vector2 panLimitX = new Vector2(10, 50); // Limite en X del mapa
    public static Vector2 panLimitZ = new Vector2(20, 50); // Limite en Z del mapa
    public static float maxRotationZ = 15f; // Rotacion maxima en Z del mapa

    public static Material damagedMaterial = Resources.Load<Material>("Materials/DamagedStructure"); // Material para cuando la resistencia es 2


    // Este m�todo restablece todas las variables globales cuando sea necesario
    public static void Reset()
    {
        damageCounter = 0;
        // Restablecer otras variables si es necesario
    }
}