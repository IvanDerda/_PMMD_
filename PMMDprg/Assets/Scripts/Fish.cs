using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fish : Animals
{
    public Text text;
    public override string Sounds()
    {
        sound = "����";
        return sound;
    }
    public void OnClick()
    {
        text.text = sound;
    }
}
