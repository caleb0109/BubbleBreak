using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Yarn.Unity;

public class SpriteChanger : MonoBehaviour
{
    //Images in the canvas
    public Image spring;
    public Image diaImg;
    public Image bub;
    public Image backgroundBlack;

    //Springs sprites
    public Sprite neutral;
    public Sprite sad;
    public Sprite blush;
    public Sprite happy;
    public Sprite thinking;
    public Sprite disgust;
    public Sprite worry;

    //Text bubble sprites
    public Sprite exclamation;
    public Sprite question;
    public Sprite normal;

    //Bub sprites
    public Sprite bNormal;
    public Sprite bNeutral;
    public Sprite bStress1;
    public Sprite bStress2;
    public Sprite bStress3;

    //narrator text bubble
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
            case "blush":
            {
                spring.sprite = blush;
                break;
            }
            case "happy":
            {
                spring.sprite = happy;
                break;
            }
            case "thinking":
            {
                spring.sprite = thinking;
                break;
            }
            case "digust":
            {
                spring.sprite = disgust;
                break;
            }
            case "worry":
            {
                spring.sprite = worry;
                break;
            }
            case "sOut":
            {
                spring.enabled = false;
                break;
            }
            case "sIn":
            {
                spring.enabled = true;
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
            case "bNeutral":
            {
                bub.sprite = bNeutral;
                break;
            }
            case "bStress1":
            {
                bub.sprite = bStress1;
                break;
            }
            case "bStress2":
            {
                bub.sprite = bStress2;
                break;
            }
            case "bStress3":
            {
                bub.sprite = bStress3;
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
