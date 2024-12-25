using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInitializer : MonoBehaviour
{
    public GameObject menuPanel;  // Panel Menu
    public GameObject homePanel;  // Panel Home (opsional)

    void Start()
    {
        // Periksa apakah ada target panel yang tersimpan
        string targetPanel = PlayerPrefs.GetString("TargetPanel", "");

        // Reset PlayerPrefs agar tidak memengaruhi reload berikutnya
        PlayerPrefs.SetString("TargetPanel", "");
        PlayerPrefs.Save();

        // Tampilkan panel sesuai target
        if (targetPanel == "Menu")
        {
            menuPanel.SetActive(true);
            if (homePanel != null)
                homePanel.SetActive(false); // Nonaktifkan panel lain (opsional)
        }
        else
        {
            // Jika tidak ada target, tetap ke default (misalnya Home)
            if (menuPanel != null)
                menuPanel.SetActive(false);
            if (homePanel != null)
                homePanel.SetActive(true);
        }
    }
}
