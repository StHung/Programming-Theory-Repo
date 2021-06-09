using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GUIManager : MonoBehaviour
{
    public static GUIManager Instance = new GUIManager();
    public TextMeshProUGUI animalsInfoText;

    private void Awake()
    {
        Instance = this;  
    }

    

    public void SetText(string text)
    {
        animalsInfoText.text = text;
    }
}
