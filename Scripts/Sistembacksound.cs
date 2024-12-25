using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sistembacksound : MonoBehaviour
{
    public static Sistembacksound instance;
    public AudioSource SuaraMusik;

    public void OnEnable(){
        if(instance == null){
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else{
            Destroy(gameObject);
        }
    }

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
