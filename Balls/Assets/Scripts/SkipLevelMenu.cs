using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkipLevelMenu : MonoBehaviour
{
    public PlayerState playerState;
    public GameConfig gameConfig;
    public Text levelText;

    int level;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = Vector3.zero;
        level = playerState.level;
        int visibleLevel = level + 1;
        levelText.text = visibleLevel.ToString();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMenu()
    {
        gameObject.SetActive(true);
    }

    public void lowerLevel()
    {
        level--;
        int visibleLevel = level + 1;
        levelText.text = visibleLevel.ToString();
    }

    public void highterLevel()
    {
        level++;
        int visibleLevel = level + 1;
        levelText.text = visibleLevel.ToString();
    }

    public void Go()
    {
        playerState.level = level;
        playerState.Save();
        SceneManager.LoadScene(1);
    }
}
