using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class JumpMapManager : MonoBehaviour
{
    public static JumpMapManager Instance;

    [Header("Player")]
    [SerializeField] private Transform player;

    [Header("Fall / Death")]
    [SerializeField] private float fallY = -5f;

    [Header("Clear UI")]
    [SerializeField] private TMP_Text clearText;

    private bool isCleared = false;
    private bool isRestarting = false;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        if (clearText != null)
        {
            clearText.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
        if (player == null)
            return;

        // 맵 아래로 떨어졌을 경우
        if (!isCleared && !isRestarting && player.position.y < fallY)
        {
            RestartLevel();
        }
    }

    public void ClearLevel()
    {
        if (isCleared)
            return;

        isCleared = true;

        if (clearText != null)
        {
            clearText.text = "CLEAR!";
            clearText.gameObject.SetActive(true);
        }

        Debug.Log("STAGE CLEAR!");
    }

    private void RestartLevel()
    {
        isRestarting = true;

        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.name);
    }
}