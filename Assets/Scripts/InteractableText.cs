using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InteractableText : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private TextMeshProUGUI content;

    void Start()
    {
     content = panel.GetComponentInChildren<TextMeshProUGUI>();
    }

   public void FileRead(string textToRead){
    panel.SetActive(true);
    content.text = textToRead;
   }
}
