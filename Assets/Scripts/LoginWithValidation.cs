using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class LoginWithValidation : MonoBehaviour
{
  public TMP_InputField nomeDeUsuarioInputField;
  public TMP_InputField senhaInputField;
  public TMP_InputField validationFailedoutputArea;

  public Button botao;

  private void Start()
  {
    botao.onClick.AddListener(ObterNomeDeUsuario);
  }

  public void ObterNomeDeUsuario()
  {
    string nomeDeUsuario = nomeDeUsuarioInputField.text;
    string senha = senhaInputField.text;

    if (nomeDeUsuario == "annimar@annimar.com" && senha == "123456")
    {
      UnityEngine.SceneManagement.SceneManager.LoadScene("Sphere");
    }
    else
    {
      validationFailedoutputArea.text = ("Nome de usuário e/ou senha incorretos!");
    }
  }
}
