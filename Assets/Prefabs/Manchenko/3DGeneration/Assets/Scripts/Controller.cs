using System;
using UnityEngine;

[RequireComponent(typeof(MazeConstructor))]

public class Controller : MonoBehaviour
{
    private MazeConstructor generator;

    void Start()
    {
        generator = GetComponent<MazeConstructor>();

        generator.GenerateNewMaze(13, 15);
    }
}