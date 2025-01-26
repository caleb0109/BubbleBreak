using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class IntroScene : MonoBehaviour
{
    [SerializeField] private CanvasGroup canvasGroup;

    public Image cutScene;
    public Sprite cut1;
    public Sprite cut2;
    public Sprite cut3;
    public Sprite cut4;
    //public float timeToFade;
    
    private string nScene;
    // private bool fadeIn = false;
    // private bool fadeOut = false;


    void Start() {
        nScene = "";
    }
    // // Update is called once per frame
    // void Update()
    // {
    //    if(fadeIn)
    //    {
    //     if(canvasGroup.alpha < 1)
    //     {
    //         canvasGroup.alpha += timeToFade * Time.deltaTime;
    //         if(canvasGroup.alpha == 0)
    //         {
    //             fadeIn = false;
    //         }
    //     }

    //     if(fadeOut)
    //     {
    //         canvasGroup.alpha -= timeToFade * Time.deltaTime;
    //         if(canvasGroup.alpha == 0)
    //         {
    //             fadeOut = false;
    //         }
    //     }
    //    } 
    // }

    // public void FadeIn()
    // {
    //     fadeIn = true;
    // }

    // public void FadeOut()
    // {
    //     fadeOut = true;
    // }

    [YarnCommand("NextScene")]
    public void NextScene(string next)
    {
        nScene = next;
        switch(nScene)
        {
            case "cut1":
            {
                cutScene.sprite = cut1;
                cutScene.enabled = true;
                break;

            }
            case "cut2":
            {
                cutScene.sprite = cut2;
                break;

            }
            case "cut3":
            {
                cutScene.sprite = cut3;
                break;

            }
            case "cut4":
            {
                cutScene.sprite = cut4;
                break;

            }
            default:
            {
                cutScene.enabled = false;
                break;
            }
        }
    }

}
