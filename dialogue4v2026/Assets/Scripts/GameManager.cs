using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public enum GameState
    {
        Iniciando,
        MenuPrincipal,
        Gameplay
    }

    public GameState currentState;

    private void Awake()
    {
        // Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SetState(GameState.Iniciando);
    }

    public void SetState(GameState newState)
    {
        currentState = newState;
        Debug.Log("Estado atual: " + currentState);
    }

    // Controle de cenas
    public void LoadScene(string sceneName)
    {
        if (currentState == GameState.Iniciando ||
            currentState == GameState.MenuPrincipal ||
            currentState == GameState.Gameplay)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    // Configuração de input
    public void SetupPlayerInput(PlayerInput player)
    {
        player.ActivateInput();
    }
}