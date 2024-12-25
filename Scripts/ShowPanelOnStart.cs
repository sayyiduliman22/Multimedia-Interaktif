using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPanelOnStart : MonoBehaviour
{
    public GameObject homePanel; // Referensi ke Panel Home
    public GameObject menuPanel; // Referensi ke Panel Menu

    void Start()
    {
        // Debug nilai PlayerPrefs
        Debug.Log("ShowMenu Value: " + PlayerPrefs.GetInt("ShowMenu", 0));

        if (PlayerPrefs.HasKey("ShowMenu") && PlayerPrefs.GetInt("ShowMenu") == 1)
        {
            Debug.Log("Menampilkan Panel Menu");
            menuPanel.SetActive(true);
            Debug.Log("menuPanel Active: " + menuPanel.activeSelf);

            homePanel.SetActive(false);
            Debug.Log("homePanel Active: " + homePanel.activeSelf);

            // Reset nilai PlayerPrefs
            PlayerPrefs.SetInt("ShowMenu", 0);
            PlayerPrefs.Save();
        }
        else
        {
            Debug.Log("Menampilkan Panel Home");
            menuPanel.SetActive(false);
            Debug.Log("menuPanel Active: " + menuPanel.activeSelf);

            homePanel.SetActive(true);
            Debug.Log("homePanel Active: " + homePanel.activeSelf);
        }
    }
}
