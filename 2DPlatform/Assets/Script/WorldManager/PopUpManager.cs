using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpManager : MonoBehaviour
{
    [Header("hide")]
    [SerializeField] private GameObject hideShow;

    private void Awake()
    {
        hideShow.SetActive(false);
    }
    public void showPopUp()
    {
        hideShow.SetActive(true);
    }

    public void hidePopUp()
    {
        hideShow.SetActive(false);
    }
}
