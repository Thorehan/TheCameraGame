using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerUI : MonoBehaviour
{

    [SerializeField] private TextMeshProUGUI interactText;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void UpdateText(string promptMessage)
    {
        interactText.text = promptMessage;
    }
}
