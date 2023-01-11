using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoEspadaCorto : MonoBehaviour
{
    public GameObject ataqueLargo;
    public GameObject particulasMagicDark;
    public ParticleSystem magicDark;
    public bool click = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (click == true)
        {
            StartCoroutine(DañoEnemigo());
        }
    }


    IEnumerator DañoEnemigo()
    {

        particulasMagicDark.SetActive(true);
        yield return new WaitForSeconds(3);
        click = false;
        ataqueLargo.SetActive(false);
        particulasMagicDark.SetActive(false);



    }
}
