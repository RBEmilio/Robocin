using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionShow_Hide : MonoBehaviour
{
    [SerializeField] private GameObject options;

    private void Awake()
    {
        hideOption();
    }

    public void hideOption() { options.SetActive(false); }

    public void showOption() { options.SetActive(true); }
}
