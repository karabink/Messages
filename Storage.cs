using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storage : MonoBehaviour
{
    public static int Doors = 0;
    public static int Lives = 1;

    public static bool GameOver = false;

    public static void SetLives(int value)
    {
        Lives = value;
        if (Lives == 0)
        {
            GameOver = true;
            Time.timeScale = 0f;
        };
    }

}