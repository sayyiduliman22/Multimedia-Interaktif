using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exitconfirmation : MonoBehaviour
{
    [SerializeField] GameObject exitPanel;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (SceneManager.GetActiveScene ().buildIndex!=0){
                SceneManager.LoadScene(0);
            }
            else{
                if (exitPanel){
                    exitPanel.SetActive(true);
                }
            }
        }
    }

    public void onUserClickYesNo(int choice){ //choice 0 = no, choice 1 = yes
        if (choice==1){
            Application.Quit();
        }
        exitPanel.SetActive(false); //else
    }
}
