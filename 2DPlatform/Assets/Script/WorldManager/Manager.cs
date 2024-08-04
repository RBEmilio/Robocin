using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public static Manager Instance;
    [Header ("buttons")]
    public Button[] levelsButtons;
    public int levelUnlock;      

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }        
    }

    private void Start()
    {
        if (levelsButtons.Length > 0)
        {
            for(int i = 0; i < levelsButtons.Length; i++)
            {
                levelsButtons[i].interactable = false;
            }

            for(int i = 0;i < PlayerPrefs.GetInt("levelsUnlock", 1); i++)
            {
                levelsButtons[i].interactable = true;
            }
        }
    }

    public void MoreLevels()
    {
        if(levelUnlock > PlayerPrefs.GetInt("levelsUnlock", 1))
        {
            PlayerPrefs.SetInt("levelsUnlock", levelUnlock);
        }
    }
  
}
