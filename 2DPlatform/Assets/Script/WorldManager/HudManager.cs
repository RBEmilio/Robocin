using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HudManager : MonoBehaviour
{
    #region Utils
    [Header("Utilities")]
    [SerializeField] private GameManager gameManager;
    [SerializeField] TextMeshProUGUI points;
    [SerializeField] TextMeshProUGUI finalPoints;
    [SerializeField] private int nivel;
    #endregion

    #region Help
    [Header("Help")]
    [SerializeField] private GameObject hide1;
    [SerializeField] private GameObject hide2;
    [SerializeField] private GameObject hide3;
    [SerializeField] private GameObject hide4;
    [SerializeField] private GameObject hide5;

    #endregion

    private void Start()
    {
        hide1.SetActive(false);
        hide2.SetActive(false);
        hide3.SetActive(false);
        hide4.SetActive(false);
        hide5.SetActive(false);
    }

    private void Update()
    {
        points.text = gameManager.TotalPoints.ToString();
        finalPoints.text = gameManager.TotalPoints.ToString();
    }

    public void ToMenu()
    {
        string nivelPoints = gameManager.TotalPoints.ToString();

        if (Manager.Instance != null)
        {
            Manager.Instance.MoreLevels();
        }
        if(nivel == 1)
        {
            
            PlayerPrefs.SetString("nivel1", nivelPoints);
        }
        else if(nivel == 2)
        {
            PlayerPrefs.SetString("nivel2", nivelPoints);

        }else if(nivel == 3)
        {
            PlayerPrefs.SetString("nivel3", nivelPoints);
        }else if (nivel == 4)
        {
            PlayerPrefs.SetString("nivel4", nivelPoints);
        }

        SceneManager.LoadScene("StartMenu");
    }
}
