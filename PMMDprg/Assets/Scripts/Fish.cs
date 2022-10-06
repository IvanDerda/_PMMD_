using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Fish : Animals
{
    public Text text;
    public Text text1;
    public override string Sounds()
    {
        sound = "Буль";
        return sound;
    }
    public void OnClick()
    {
        text.text = sound;
        text1.text = "";
    }

    public override void Fly()
    {
        throw new System.NotImplementedException();
    }
}
