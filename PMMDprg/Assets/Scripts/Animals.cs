using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animals : MonoBehaviour
{
    public string sound;

    private int step;

    public abstract string Sounds();
}

public interface Move
{
    void Run();
}
