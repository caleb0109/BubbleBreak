using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Yarn.Unity;

public class SpriteChanger : MonoBehaviour
{
    
    private string curr;

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

    public GameObject springObj;
    

    // Start is called before the first frame update
    void Start()
    {
        curr = "default";
    }

    // Update is called once per frame
    void Update()
    {
        //i will change this in the future, please dont hurt me
        springObj.transform.localScale = new Vector3(1.440132f,1.440132f,1.440132f);
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
                springObj.GetComponent<Animator>().enabled = false;
                break;
            }
            case "blush":
            {
                spring.sprite = blush;
                springObj.GetComponent<Animator>().enabled = false;
                break;
            }
            case "happy":
            {
                spring.sprite = happy;
                springObj.GetComponent<Animator>().enabled = false;
                break;
            }
            case "thinking":
            {
                spring.sprite = thinking;
                springObj.GetComponent<Animator>().enabled = false;
                break;
            }
            case "disgust":
            {
                spring.sprite = disgust;
                springObj.GetComponent<Animator>().enabled = false;
                break;
            }
            case "worry":
            {
                spring.sprite = worry;
                springObj.GetComponent<Animator>().enabled = false;
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
                springObj.GetComponent<Animator>().enabled = true;
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
