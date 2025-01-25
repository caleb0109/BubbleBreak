using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSet : MonoBehaviour
{
    public int currStage;

    // Start is called before the first frame update
    void Start()
    {
        currStage = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //properly loads the textfiles for the current stage, resets stress and affection, 
    //and plays animation for reset 
    public void StageReset()
    {
        switch (currStage)
        {
            case 1:
            break;
            case 2:
            break;
            default:
            break;
        }
    }
}
