using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Perot : Animals
{
    public Text text;
    public override string Sounds()
    {
        sound = "Привіт";
        return sound;
    }
    public void OnClick()
    {
        text.text = sound;
    }
}
