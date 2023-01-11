using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsOpener : MonoBehaviour
{
    public GameObject panelAttack;
    
    // Start is called before the first frame update
    public void OpenPanelAttack()
    {
        if(panelAttack != null)
        {
            bool isActive = panelAttack.activeSelf;
           
            panelAttack.SetActive(!isActive);
        }
        
    }
}
