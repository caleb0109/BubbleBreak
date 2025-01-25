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
    public Sprite neutral;
    public Sprite sad;
    public Sprite exclamation;
    public Sprite question;
    public Sprite normal;


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
            default:
            {
                spring.sprite = neutral;
                break;
            }
            
        }
    }
}
