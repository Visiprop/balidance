using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class UIManager : Singleton<UIManager>
{
    public Image bgImage;
    public Sprite[] bgSprites;
     public Image photoImage;
    public Sprite[] photoSprites;
    public GameObject InfoBox;
    public GameObject WinPanel;
    public Text CountText;

    private float defTime = 16;
    private float time;

    private bool activated;

    // Start is called before the first frame update
    void Start()
    {

        time = defTime;
        bgImage.sprite = bgSprites[PlayerPrefs.GetInt("GerakanIndex", 0)];
        photoImage.sprite = photoSprites[PlayerPrefs.GetInt("GerakanIndex", 0)];
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0){
            if(activated){
                time -= Time.deltaTime;
                CountText.text = Math.Round(time) + "";
            }else
            {
                time = defTime;
                CountText.text = Math.Round(time) + "";
            }
        }

        if(time <= 0){
            WinPanel.SetActive(true);
        }
    }

    public void ActiveInfoBox(bool active){
        // InfoBox.SetActive(active);
        CountText.gameObject.SetActive(active);
        activated = active;
    }
}
