using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeManaPlayer2 : MonoBehaviour
{
    public Image  manaBar;
    
    public Text manaText;

    public float myLife;
    public float myMana;

    private float currentLife;
    private float currentMana;
    private float calculateLife;
    // Start is called before the first frame update
    void Start()
    {
        currentLife = myLife;
        currentMana = myMana;

    }

    // Update is called once per frame
    void Update()
    {
        calculateLife = currentLife / myLife;
       

        if (currentMana < myMana)
        {
            manaBar.fillAmount = Mathf.MoveTowards(manaBar.fillAmount, 1f, Time.deltaTime * 0.01f);
            currentMana = Mathf.MoveTowards(currentMana / myMana, 1f, Time.deltaTime * 0.01f) * myMana;
        }
        if (currentMana < 0)
        {
            currentMana = 0;

        }
        manaText.text = "" + Mathf.FloorToInt(currentMana);
    }
    public void Damage(float damage)
    {
        currentLife -= damage;
    }
    public void ReduceMana(float mana)
    {
        currentMana -= mana;
        manaBar.fillAmount -= mana / myMana;
    }
}
