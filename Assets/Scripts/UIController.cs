using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject ui;

    public void _ShowHideUI()
    {
        if (ui != null)
        {
            if (ui.activeSelf)
            {
                ui.SetActive(false);
            }
            else
            {
                ui.SetActive(true);
            }
        }
    }
}
