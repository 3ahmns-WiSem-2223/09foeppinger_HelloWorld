using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountingScript : MonoBehaviour
{

    public TextMeshProUGUI text;
    public int number;

    public void Up()
    {
        
        number++;
        text.text = number.ToString();
    }

    public void Down()
    {
        if (number >= 1)
        {
            number--;
            text.text = number.ToString();
        }
        else
        {

        }
    }

    public void ResetCounter()
    {
        number = 0;
        text.text = number.ToString();
    }

    public void UpTen()
    {
        number += 10;
        text.text = number.ToString();
    }

    public void DownTen()
    {
        number -= 10;
        text.text = number.ToString();
    }

    public void TimesTwo()
    {
        number *= 2;
        text.text = number.ToString();
    }

    public void DividedByTwo()
    {
        number /= 2;
        text.text = number.ToString();
    }
}
