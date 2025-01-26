using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Yarn.Unity;

public class SpriteChanger : MonoBehaviour
{
    //public Sprite angry;
    public Image spring;
    public Image diaImg;
    public Image bub;
    public Image backgroundBlack;

    public Sprite neutral;
    public Sprite sad;
    public Sprite exclamation;
    public Sprite question;
    public Sprite normal;
    public Sprite bNormal;
    public Sprite bNeutral;
    public Sprite bStress1;
    public Sprite bStress2;
    public Sprite bStress3;
    public Sprite narr;
    


    private string curr;
    // Start is called before the first frame update
    void Start()
    {
        curr = "default";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [YarnCommand("ChangeSprite")]
    public void ChangeSprite(string state)
    {
        curr = state;
        switch(curr)
        {
            case "sad":
            {
                spring.sprite = sad;
                break;
            }
            case "exclamation":
            {
                diaImg.sprite = exclamation;
                break;
            }
            case "question":
            {
                diaImg.sprite = question;
                break;
            }
            case "normal":
            {
                diaImg.sprite = normal;
                break;
            }
            case "bNormal":
            {
                diaImg.sprite = bNormal;
                break;
            }
            case "narr":
            {
                diaImg.sprite = narr;
                break;
            }
            default:
            {
                spring.sprite = neutral;
                break;
            }
            
        }
    }

    [YarnCommand("BlackBackground")]
    public void BlackBackground(string state)
    {
        curr = state;
        switch(curr)
        {
            case "on":
            {
                backgroundBlack.enabled = true;
                break;
            }
            case "off":
            {
                backgroundBlack.enabled = false;
                break;
            }
            default:
            {
                backgroundBlack.enabled = false;
                break;
            }
        }
    }
}
