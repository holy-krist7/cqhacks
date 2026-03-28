using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomFontParser : MonoBehaviour
{
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
    }

    private void Start()
    {
        SetText("1010");
    }

    public void SetText(string s)
    {
        string newString = "";
        foreach (char c in s)
        {
            newString += "<sprite index=" + charIds[c].ToString() + ">";
        }
        text.text = newString;
    }
}
