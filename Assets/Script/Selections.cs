using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selections : MonoBehaviour
{
    private Renderer renderer;
    public GameObject panelBarPlayer1, panelBarPlayer2;
    public GameObject optionsPlayer1,optionsPlayer2;
    public GameObject powerUpsPlayer1, powerUpsPlayer2;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Player")
                {
                    powerUpsPlayer2.SetActive(false);
                    optionsPlayer1.SetActive(true);
                    optionsPlayer2.SetActive(false);
                    panelBarPlayer1.SetActive(true);
                    panelBarPlayer2.SetActive(false);
                    Debug.Log(hit.transform.name);
                }
                if (hit.transform.tag == "Player2")
                {
                    powerUpsPlayer1.SetActive(false);
                    optionsPlayer1.SetActive(false);
                    optionsPlayer2.SetActive(true);
                    panelBarPlayer1.SetActive(false);
                    panelBarPlayer2.SetActive(true);
                }
            }
        }
    }
    private void OnMouseEnter()
    {
        renderer.material.color = Color.red;
    }
    private void OnMouseExit()
    {
        renderer.material.color = Color.blue;

    }

   /* public void OpenPanelPlayer1()
    {
        if(panelBarPlayer1 == null)
        {
            gameObject.SetActive(true);
        }
    }*/
    
    
}
