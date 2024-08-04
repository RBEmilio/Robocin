using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CargarPuntos : MonoBehaviour
{

    [Header("Points")]
    [SerializeField] private TextMeshProUGUI pointsLv1;
    [SerializeField] private TextMeshProUGUI pointsLv2;
    [SerializeField] private TextMeshProUGUI pointsLv3;
    [SerializeField] private TextMeshProUGUI pointsLv4;

    private void Start()
    {
        if (!PlayerPrefs.HasKey("nivel1"))
        {
            PlayerPrefs.SetString("nivel1", "0");
            pointsLv1.text = PlayerPrefs.GetString("nivel1");
        }
        else
        {
            Debug.Log(PlayerPrefs.GetString("nivel1"));
            pointsLv1.text = PlayerPrefs.GetString("nivel1");
        }

        if (!PlayerPrefs.HasKey("nivel2"))
        {
            PlayerPrefs.SetString("nivel2", "0");
            pointsLv2.text = PlayerPrefs.GetString("nivel2");
        }
        else
        {
            pointsLv2.text = PlayerPrefs.GetString("nivel2");
        }
        if (!PlayerPrefs.HasKey("nivel3"))
        {
            PlayerPrefs.SetString("nivel3", "0");
            pointsLv3.text = PlayerPrefs.GetString("nivel3");
        }
        else
        {
            pointsLv3.text = PlayerPrefs.GetString("nivel3");
            Debug.Log(PlayerPrefs.GetString("nivel3"));
        }
        if (!PlayerPrefs.HasKey("nivel4"))
        {
            PlayerPrefs.SetString("nivel4", "0");
            pointsLv4.text = PlayerPrefs.GetString("nivel4");
        }
        else
        {
            pointsLv4.text = PlayerPrefs.GetString("nivel4");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
