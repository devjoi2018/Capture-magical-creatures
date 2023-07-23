using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundRandomColor : MonoBehaviour
{
    [Tooltip("Imagen a la que se le cambiará el color")]
    [SerializeField] private Image image;
    [Tooltip("Lista de colores para cambiar el color de la imagen")]
    [SerializeField] private List<Color> colors;

    [Tooltip("Duración de la transición entre colores")]
    [SerializeField] private float transitionDuration = 1f;

    private int currentIndex = 0;
    private Color currentColor;
    private Color nextColor;
    private float transitionTimer = 0f;

    private void Start()
    {
        // Asignar el primer color de la lista a la imagen
        currentColor = colors[0];
        image.color = currentColor;
    }

    private void Update()
    {
        // Actualizar el temporizador de transición
        transitionTimer += Time.deltaTime;

        // Si el temporizador ha superado la duración de la transición, cambiar al siguiente color
        if (transitionTimer >= transitionDuration)
        {
            // Incrementar el índice del color actual
            currentIndex++;
            if (currentIndex >= colors.Count)
            {
                currentIndex = 0;
            }

            // Asignar el siguiente color y reiniciar el temporizador de transición
            currentColor = nextColor;
            nextColor = colors[currentIndex];
            transitionTimer = 0f;
        }

        // Calcular el valor de interpolación entre los colores actual y siguiente
        float t = transitionTimer / transitionDuration;
        Color newColor = Color.Lerp(currentColor, nextColor, t);
        newColor.a = 1f; // Mantener el canal alfa en 1
        image.color = newColor;
    }
}