using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DañoPlayerViento : MonoBehaviour
{
     DañoPLayer2 vida;
    public GameObject ataqueLargo;
    public GameObject particulasMagicDark;
    public ParticleSystem magicDark;
    public bool click = false;
    public Image barraVIda;
    public float vidaMaxima;
    public float dañoViento = 0.25f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        vida = GetComponent<DañoPLayer2>();
        
    }

    // Update is called once per frame
    public void OnMouseDown()
    {

        if (click == true)
        {

            vida.DañoViento();
            StartCoroutine(DañoEnemigo());
            click = false;
            ataqueLargo.SetActive(false);

        }
        



    }

    IEnumerator DañoEnemigo()
    {

        particulasMagicDark.SetActive(true);
        yield return new WaitForSeconds(1);
        particulasMagicDark.SetActive(false);



    }
}
