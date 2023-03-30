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
        Debug.Log("O nome de usuário inserido foi: " + nomeDeUsuario + " e a senha inserida foi: " + senha);

        if(nomeDeUsuario == "admin")
        {
             UnityEngine.SceneManagement.SceneManager.LoadScene("Sphere");  
        }
        else
        {
            validationFailedoutputArea.text = ("O nome de usuário inserido é inválido!");
            Debug.Log("O nome de usuário inserido é inválido!");
        }
    }
}
