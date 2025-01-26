using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class StressAndAffection : MonoBehaviour
{
    public int stress = 0;
    public int affection = 0;
    public AffectionBar affBar;
    public StageSet stage;
    int hi = 0;

    private int stage2Check = 50;
    private int stage3Check = 100;

    [YarnCommand("StressEffect")]
    public int StressEffect (int add )
    {
        stress += add;
        if(stress <= 0)
        {
            stress = 0;
        }
        else if (stress >= 100)
        {
            stress = 0;
            affection = 0;
            stage.StageReset();
            hi = 1;
            return hi;
        }
        return hi;
    } 

    [YarnCommand("AffectionEffect")]
    public void AffectionEffect (int add)
    {
        affection += add;
        affBar.curr = affection;
        if(affBar.bar.enabled == false)
        {
            affBar.ShowBar();
        }
        Debug.Log("yes");
    }

}


