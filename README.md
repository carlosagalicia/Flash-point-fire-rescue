# Flash Point: Fire Rescue - Simulación y Visualización

Este proyecto combina Python y Unity para simular y visualizar el juego de mesa "Flash Point: Fire Rescue". La lógica del juego está implementada en el archivo principal `firefighterv2.py`, permitiendo a la computadora jugar de forma automática y estratégica realizando la simulación en Python, y generando un archivo JSON que Unity utiliza para mostrar los movimientos y eventos del juego en un entorno visual 3D en Unity.

## Descripción General

- **Simulación:** Python genera los datos del juego en formato JSON.
- **Visualización:** Unity consume el archivo JSON y representa gráficamente los movimientos y eventos del juego.
- **Objetivo:** Crear una experiencia completa que combina la lógica automatizada del juego con una interfaz visual atractiva.

## Temas Principales de Aprendizaje

### 1. Simulación con Python
- **Generación de Datos:**
  - Implementación de las reglas del juego para simular turnos, movimientos, y eventos como incendios y explosiones.
  - Uso de estructuras de datos para modelar el tablero, los bomberos y los objetivos del juego.
- **Programación Orientada a Objetos (OOP):**
   - Modelado de los elementos del juego (bomberos, edificios, fuego) como clases.
   - Uso de métodos para definir las interacciones entre los elementos.
- **Simulación de Juegos:**
   - Implementación de las reglas del juego "Flash Point: Fire Rescue".
   - Simulación de eventos aleatorios como explosiones o propagación de fuego.
- **Estrategias Automatizadas:**
   - Algoritmos para tomar decisiones óptimas en función del estado del tablero.
- **Exportación a JSON:**
  - Serialización de los datos del estado del juego en un archivo JSON para ser consumido por Unity.

### 2. Representación Visual con Unity
- **Importación de JSON:**
  - Uso de scripts en **C#** para leer el archivo JSON generado por Python.
  - Traducción de los datos JSON en movimientos y eventos en el motor de Unity.
- **Gráficos 3D:**
  - Representación visual del tablero del juego, los bomberos y el fuego.
  - Animaciones que muestran los movimientos y acciones en tiempo real.
- **Interactividad:**
  - Configuración de cámaras y efectos visuales para mejorar la experiencia del usuario.

## Lenguajes y Herramientas Utilizadas

### Python
- **Biblioteca `json`:** Para serializar y guardar los datos del juego.
- **Algoritmos de simulación:** Para calcular las acciones y eventos del juego.

### Unity
- **C#:** Lenguaje principal para los scripts que interpretan los datos JSON.
- **Gráficos 3D:** Modelos y animaciones para representar el tablero y los eventos del juego.
- **TextMesh Pro:** Para mostrar texto (como puntajes o mensajes) en la pantalla.

## Estructura del Proyecto

- **Python:**
  - `firefighterv2.py`: Script principal que genera la simulación y exporta el archivo JSON.

- **Unity:**
  - `Assets/Scripts`: Contiene los scripts en C# para cargar y procesar el archivo JSON.
  - `Assets/Scenes`: Escenas del juego que representan el tablero y los eventos.
  - `Assets/Models`: Modelos 3D de los personajes y objetos del juego.

## Instalación y Uso

### Requisitos
- **Python 3.x** para ejecutar la simulación.
- **Unity Hub** y una versión reciente de Unity para la visualización.

### Instrucciones

1. **Clonar el repositorio:**
   ```bash
   git clone https://github.com/usuario/flash-point-fire-rescue.git
