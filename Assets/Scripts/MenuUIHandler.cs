using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
    using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public InputField playerNameInputfield;

    public void Start()
    {
        playerNameInputfield.onValueChanged.AddListener(delegate { PlayerNameUpdate(); });
    }

    public void PlayerNameUpdate()
    {
        PermanenceManager.instance.playerName = playerNameInputfield.text;
    }

    public void StartNew()
    {
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
