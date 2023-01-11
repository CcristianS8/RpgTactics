using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DañoPLayer2 : MonoBehaviour
{
    public GameObject ataqueLargo;
    public GameObject particulasMagicDark;
    public ParticleSystem magicDark;
    public bool click = false;
    public Image barraVIda;
    public float vida;
    public float vidaMaxima;
    public float dañoVeneno = 0.15F;
    public float dañoViento = 0.25F;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void Update()
    {
        barraVIda.fillAmount = vida;
    }
    // Update is called once per frame
    public void OnMouseDown()
    {

        if (click == true)
        {
            
            vida -= dañoVeneno;
            StartCoroutine(DañoEnemigo());
            ataqueLargo.SetActive(false);
            click = false;
        }



    }

    IEnumerator DañoEnemigo()
    {

        particulasMagicDark.SetActive(true);
        yield return new WaitForSeconds(3);
        click = false;
        particulasMagicDark.SetActive(false);



    }

    public void DañoViento()
    {
        vida -= dañoViento;
    }
}
