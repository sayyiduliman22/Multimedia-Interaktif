using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnscript : MonoBehaviour
{
    public GameObject home;
    public GameObject menu;
    public GameObject pengembang;
    public GameObject info;
    public GameObject video;
    public GameObject games;
    public GameObject materi;
    public GameObject pengertian;
    public GameObject konsepmomen;
    public GameObject kesetimbangan;
    public GameObject rumus;
    // Start is called before the first frame update
    void Start(){
        home.SetActive(true);
        menu.SetActive(false);
        pengembang.SetActive(false);
        info.SetActive(false);
        video.SetActive(false);
        games.SetActive(false);
        materi.SetActive(false);
        pengertian.SetActive(false);
        konsepmomen.SetActive(false);
        kesetimbangan.SetActive(false);
        rumus.SetActive(false);
    }

    public void menubtnClicked(){
        home.SetActive(false);
        menu.SetActive(true);
    }

    public void infobtnClicked(){
        menu.SetActive(false);
        info.SetActive(true);
    }

    public void nextbtninfoClicked(){
        info.SetActive(false);
        pengembang.SetActive(true);
    }

    public void gamesbtnClicked(){
        menu.SetActive(false);
        games.SetActive(true);
    }

    public void backbtnmenuClicked(){
        home.SetActive(true);
        menu.SetActive(false);
    }

    public void backbtnpengembangClicked(){
        info.SetActive(true);
        pengembang.SetActive(false);
    }

    public void nextbtnpengembangClicked(){
        pengembang.SetActive(false);
        menu.SetActive(true);
    }

    public void backbtninfoClicked(){
        menu.SetActive(true);
        info.SetActive(false);
    }

    public void videobtnClicked(){
        menu.SetActive(false);
        video.SetActive(true);
    }

    public void backbtnvideoClicked(){
        menu.SetActive(true);
        video.SetActive(false);
    }

    public void backbtngamesClicked(){
        menu.SetActive(true);
        games.SetActive(false);
    }

    public void materibtnClicked(){
        materi.SetActive(true);
        menu.SetActive(false);
    }

    public void backbtnmateriClicked(){
        menu.SetActive(true);
        materi.SetActive(false);
    }

    public void pengertianbtnmateriClicked(){
        pengertian.SetActive(true);
        materi.SetActive(false);
    }

    public void konsepbtnmateriClicked(){
        konsepmomen.SetActive(true);
        materi.SetActive(false);
    }

    public void rumusbtnmateriClicked(){
        rumus.SetActive(true);
        materi.SetActive(false);
    }

    public void backbtnpengertianClicked(){
        materi.SetActive(true);
        pengertian.SetActive(false);
    }

    public void menubtnpengertianClicked(){
        menu.SetActive(true);
        pengertian.SetActive(false);
    }

    public void backbtnkonsepmomenClicked(){
        materi.SetActive(true);
        konsepmomen.SetActive(false);
    }

    public void menubtnkonsepmomenClicked(){
        menu.SetActive(true);
        konsepmomen.SetActive(false);
    }

    public void nextbtnkonsepmomenClicked(){
        kesetimbangan.SetActive(true);
        konsepmomen.SetActive(false);
    }

    public void backbtnkesetimbanganClicked(){
        materi.SetActive(true);
        kesetimbangan.SetActive(false);
    }

    public void menubtnkesetimbanganClicked(){
        menu.SetActive(true);
        kesetimbangan.SetActive(false);
    }

    public void backbtnrumusClicked(){
        materi.SetActive(true);
        rumus.SetActive(false);
    }

    public void menubtnrumusClicked(){
        menu.SetActive(true);
        rumus.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
