using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HomeManager : MonoBehaviour
{
    public GameObject[] Pages;
    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetInt("Startup", 1) == 0){
            Pages[0].SetActive(true);
            Pages[1].SetActive(true);
        }

        if(SceneManager.GetActiveScene().name == "Home"){
			PlayerPrefs.SetInt("Startup", 0);
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectGerakan(int i ){
        PlayerPrefs.SetInt("GerakanIndex", i);
    }
}
