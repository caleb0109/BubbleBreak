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

    private int stage2Check = 50;
    private int stage3Check = 100;


    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {

    }
    
    [YarnFunction("StressEffect")]
    public static StressEffect (int add, int )
    {
        stress += add;
        if(stress <= 0)
        {
            stress = 0;
        }
        else if (stress >= 100)
        {
            return stress;
            stress = 0;
            affection = 0;
            stage.StageReset();
        }
        return stress;
    } 

    [YarnFunction("AffectionEffect")]
    public static AffectionEffect (int add)
    {
        affection += add;
        affBar.curr = affection;
        return affection;

    }

}
