using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisminiucionVidaPaladin : MonoBehaviour
{


    public Image barraVIda;
    public float vida;
    public float vidaMaxima;
    public float dañoVeneno = 50;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        barraVIda.fillAmount = vida / vidaMaxima;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("player2"))
        {
            
            vida -= dañoVeneno;
            barraVIda.fillAmount -= dañoVeneno;
           
            
        }
    }
}
