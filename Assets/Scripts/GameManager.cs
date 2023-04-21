using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI TextScore1;
    public TextMeshProUGUI TextScore2;
    public BallMovement ball;

    private void Start()
    {
        ball.OnGoal += OnGoalDelegate;
    }

    private void OnGoalDelegate(object sender, EventArgs e)
    {
        Debug.Log("GameManager GOOOOOL");
        OnGoalArgs args = e as OnGoalArgs;
        if (args.jugador == TipoJugador.JUG1)
        {
            // Agregar Puntaje al jugador 1
            int puntaje = int.Parse(TextScore1.text);
            TextScore1.text = (puntaje + 1).ToString();
        }else
        {
            // Agregar Puntaje al jugador 2
            int puntaje = int.Parse(TextScore2.text);
            TextScore2.text = (puntaje + 1).ToString();
        }
    }
}
