using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomFontParser : MonoBehaviour
{
    [SerializeField] string startingText;
    [SerializeField] private TMPro.TextMeshProUGUI text;
    private Dictionary<char, int> charIds = new();

    private void Awake()
    {
        charIds.Add('1', 1);
        charIds.Add('2', 2);
        charIds.Add('3', 3);
        charIds.Add('4', 4);
        charIds.Add('5', 5);
        charIds.Add('6', 6);
        charIds.Add('7', 7);
        charIds.Add('8', 8);
        charIds.Add('9', 9);
        charIds.Add('0', 10);
        charIds.Add(':', 0);
        charIds.Add('L', 11);
        charIds.Add('A', 12);
        charIds.Add('P', 13);
        charIds.Add('S', 14);
        charIds.Add('/', 15);
    }

    private void Start()
    {
        SetText(startingText);
    }

    public void SetText(string s)
    {
        string newString = "";
        foreach (char c in s)
        {
            if (c == ' ')
            {
                newString += ' ';
                continue;
            }
            newString += "<sprite index=" + charIds[c].ToString() + ">";
        }
        text.text = newString;
    }
}
