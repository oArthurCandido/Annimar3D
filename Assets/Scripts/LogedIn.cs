using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LogedIn : MonoBehaviour
{
    public TMP_InputField outputArea;
    // Start is called before the first frame update
    void Start()
    {
        LogedMessage();
    }

    // Update is called once per frame
  
   public void LogedMessage()
   {
       outputArea.text = ("Login efetuado com sucesso!");
   }
}
