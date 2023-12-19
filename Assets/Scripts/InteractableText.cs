using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InteractableText : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private TextMeshProUGUI content;
    private bool isCursorVisible = true;
    [SerializeField] private Button button;

    void Start()
    {
     content = panel.GetComponentInChildren<TextMeshProUGUI>();
      HideCursor();
    }

   public void FileRead(string textToRead){
    panel.SetActive(true);
    button.Select();
    content.text = textToRead;
    ShowCursor();
   }   

   

    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleCursorVisibility();
        }
    }

    void ToggleCursorVisibility()
    {
        isCursorVisible = !isCursorVisible;

        if (isCursorVisible)
        {
            ShowCursor();
        }
        else
        {
            HideCursor();
        }
    }

    void ShowCursor()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    void HideCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


}
