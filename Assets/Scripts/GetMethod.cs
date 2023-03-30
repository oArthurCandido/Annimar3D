using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using TMPro;


public class GetMethod : MonoBehaviour
{
  public TMP_InputField outputArea;

  void Start()
  {

    GetData();
  }

  void GetData() => StartCoroutine(GetData_Coroutine());



  IEnumerator GetData_Coroutine()
  {
    outputArea.text = "Loading...";
    string uri = "http://localhost:3000/";
    using (UnityWebRequest request = UnityWebRequest.Get(uri))
    {
      yield return request.SendWebRequest();
      if (UnityWebRequest.Result.ConnectionError == request.result || UnityWebRequest.Result.ProtocolError == request.result)
        outputArea.text = request.error;
      else
        outputArea.text = request.downloadHandler.text;
      Debug.Log(request.downloadHandler.text);
    }
  }


}
