using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[ExecuteInEditMode()]

public class AffectionBar : MonoBehaviour
{

    public int maxBar = 100;
    public int curr = 0;
    public Image mask;
    public Image bar;

    // Update is called once per frame
    private void Update()
    {
        GetCurrentFill();
    }  

    void GetCurrentFill()
    {
        float fillAmount = (float)curr/ (float)maxBar;
        mask.fillAmount = fillAmount;
    }
    public void ShowBar()
    {
        bar.enabled = true;
        //mask.SetActive(true);
    }
}
