using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sistembutton : MonoBehaviour
{
    public GameObject BtnOn;
    public GameObject BtnOff;
    
    // Start is called before the first frame update
    void Start()
    {
        BtnOn.SetActive(true);
        BtnOff.SetActive(false);
    }

    public void Mute(){
        Sistembacksound.instance.SuaraMusik.Pause();
        BtnOff.SetActive(true);
        BtnOn.SetActive(false);
    }

    public void Aktifkan(){
        Sistembacksound.instance.SuaraMusik.UnPause();
        BtnOff.SetActive(false);
        BtnOn.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
