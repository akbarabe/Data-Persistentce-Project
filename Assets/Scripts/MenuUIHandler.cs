using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{

    public TMP_Text bestScoreText;
    public TMP_InputField nameInput;

    // Start is called before the first frame update
    void Start()
    {
        if (GameDataManager.Instance != null)
        {
            bestScoreText.text =
            $"Best Score : {GameDataManager.Instance.highScorePlayer} {GameDataManager.Instance.highScore}";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        GameDataManager.Instance.playerName = nameInput.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
