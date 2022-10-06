using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat :Animals, Move
{
    public Text text;
    public Text text1;
   public int speed;
    public override string Sounds()
    {
        sound = "Ìÿף";
        return sound;
    }
    public void OnClick()
    {
        text.text = sound;
        text1.text = "Øגטהך³סעü ג ךל/דמה " + speed.ToString();
    }

    public void Run()
    {
        speed = 10;
    }
}
