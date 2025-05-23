using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameManager : MonoBehaviour
{
    [SerializeField] private float inGameTimer;
    [SerializeField] private float inGameTimeLimit;

    private void Start()
    {
        inGameTimer = 0f;
    }
    private void Update()
    {
        inGameTimer += Time.deltaTime;
        if (inGameTimer >= inGameTimeLimit)
        {
            // Game Over logic here
            Debug.Log("Game Over");

        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
