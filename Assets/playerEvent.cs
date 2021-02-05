using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerEvent : MonoBehaviour
{
    public GameObject panel;
    public GameObject mask;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (panel != null)
        {
            panel.SetActive(true);
            mask.SetActive(false);
        }
    }
    void OnTriggerExit2D(Collider2D col)
    {
        if (panel != null)
        {
            panel.SetActive(false);
            mask.SetActive(true);
        }
    }
}
