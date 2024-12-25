using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizToMenu : MonoBehaviour
{
    public void GoToMenu()
    {
        PlayerPrefs.SetInt("ShowMenu", 1);
        PlayerPrefs.Save(); // Penting: Simpan perubahan PlayerPrefs

        // Debug untuk memastikan PlayerPrefs berhasil di-set
        Debug.Log("PlayerPrefs ShowMenu: " + PlayerPrefs.GetInt("ShowMenu"));

        // Pindah ke scene SampleScene
        SceneManager.LoadScene("SampleScene");
    }
}
