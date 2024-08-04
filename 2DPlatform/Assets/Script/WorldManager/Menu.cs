using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class Menu : MonoBehaviour
{
    #region Help
    [Header("Help Utilities")]
    [SerializeField] private GameObject hideSelector;
    [SerializeField] private GameObject OptionPanel;
    #endregion

    #region LevelShow
    [Header("Show Levels Unlock")]
    [SerializeField] private TextMeshProUGUI save1Levels;
    [SerializeField] private TextMeshProUGUI save2Levels;
    [SerializeField] private TextMeshProUGUI save3Levels;
    #endregion

    #region visualLevelShow
    private string save1, save2, save3;
    private int lvl1, lvl2, lvl3;
    [Header("DevTools")]
    public MyDataGame myDataGame1, myDataGame2, myDataGame3 = new MyDataGame();
    #endregion

    private void Awake()
    {
        save1 = Application.dataPath + "/saveFile1.json";
        save2 = Application.dataPath + "/saveFile2.json";
        save3 = Application.dataPath + "/saveFile3.json";
        UnlocksLevelShow();

        PlayerPrefs.SetString("nivel1", "0");
        PlayerPrefs.SetString("nivel2", "0");
        PlayerPrefs.SetString("nivel3", "0");
        PlayerPrefs.SetString("nivel4", "0");

        PlayerPrefs.SetInt("SaveData", 0);

        PlayerPrefs.SetInt("levelsUnlock", 0);
    }

    void Start()
    {
        hideSelector.SetActive(false);
        CLoseOptions();
    }

    // Update is called once per frame
    void Update()
    {
        UnlocksLevelShow();
    }

    private void UnlocksLevelShow()
    {
        string content1 = File.ReadAllText(save1);
        myDataGame1 = JsonUtility.FromJson<MyDataGame>(content1);
        lvl1 = myDataGame1.levelsUnlock;

        string content2 = File.ReadAllText(save2);
        myDataGame2 = JsonUtility.FromJson<MyDataGame>(content2);
        lvl2 = myDataGame2.levelsUnlock;

        string content3 = File.ReadAllText(save3);
        myDataGame3 = JsonUtility.FromJson<MyDataGame>(content3);
        lvl3 = myDataGame3.levelsUnlock;

        save1Levels.text = lvl1.ToString();
        save2Levels.text = lvl2.ToString();
        save3Levels.text = lvl3.ToString();
    }

    public void ExitGame()
    {
        Application.Quit();

        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

    public void ShowSaves()
    {
        hideSelector.SetActive(true);
    }

    public void ShowOptions()
    {
        OptionPanel.SetActive(true);
    }

    public void CLoseOptions()
    {
        OptionPanel.SetActive(false);
    }
}
