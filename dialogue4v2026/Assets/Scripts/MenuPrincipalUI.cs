using UnityEngine;

public class MenuPrincipalUI : MonoBehaviour
{
    public void IniciarJogo()
    {
        GameManager.Instance.LoadScene("SampleScene");
    }

    public void SairJogo()
    {
        Application.Quit();
    }
}