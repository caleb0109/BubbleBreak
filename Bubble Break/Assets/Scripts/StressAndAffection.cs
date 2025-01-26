using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class StressAndAffection : MonoBehaviour
{
    private static bool stressCheck = false;
    private static bool affCheck2 = false;
    private static bool affCheck3 = false;
    private static int currStage = 1;
    private int stage2Check = 50;
    private int stage3Check = 100;
    private DialogueRunner runner;

    public int stress = 0;
    public int affection = 0;
    public AffectionBar affBar;
    public SpriteChanger sChange;

    public void Start()
    {
        runner = GameObject.FindObjectOfType<DialogueRunner>();
        runner.AddFunction<bool>("stress_pop", StressPop);
        runner.AddFunction<bool>("affection_check", AffectionPass);
        currStage++;
    }

    [YarnCommand("StressEffect")]
    public void StressEffect (int add )
    {
        stress += add;
        if(stress <= 0)
        {
            stress = 0;
        }
        if(stress >= 30)
        {
            sChange.ChangeSprite("bStress1");
        }
        if(stress >= 60)
        {
            sChange.ChangeSprite("bStress2");
        }

        if (stress >= 100)
        {
            stress = 0;
            affection = 0;
            stressCheck = true;
            return;
        }
        stressCheck = false;
    }

    [YarnCommand("AffectionEffect")]
    public void AffectionEffect (int add)
    {

        affection += add;
        affBar.curr = affection;
        if(affection <= 0)
        {
            affection = 0;
        }
        if(affection >= stage2Check && currStage == 2)
        {
            affCheck2 = true;
            return;
        }
        if(affection >= stage3Check)
        {
            affCheck3 = true;
            return;
        }
        
        if(affBar.bar.enabled == false)
        {
            affBar.ShowBar();
        }
    }

    [YarnCommand("AllReset")]
    public void AllReset()
    {
        if(currStage == 3) 
        {
            affection = 30;
            
        }
        else
        {
            affection = 0;
        }
        affBar.curr = affection;
        stress = 0;
        stressCheck = false;
    }


    private static bool AffectionPass()
    {
        if(affCheck2 && currStage == 2)
        {
            currStage++;
            return true;
        }
        else if(affCheck3 && currStage == 3)
        {
            return true;
        }
        return false;
    }
    private static bool StressPop()
    {
        if(stressCheck)
        {
            return true;
        }
        return false;
    }
}


