using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{

  

    [Header("Stats")]

    public float maxHealth;
    public float maxMana;
    public float maxExp;

    public float curHealth;
    public float curMana;
    public float curExp;
    
    [Header("Reference to Health UI Elemenets")]
    public Slider healthSlider;
    public Image healthFill;
    
    [Header("Reference to Mana UI Elemenets")]
    public Slider manaSlider;
    public Image manaFill;
  

    void Update()
    {
        // if current health < deyaled health bring delayed health to match curheath Speed over time 
        healthSlider.value = Mathf.Clamp01(curHealth / maxHealth);
       
        // delayed sliders value to be set to delayed health amount not pass min and max value 
      
        ManageHealthBar();


        // if current mana < deyaled mana bring delayed mana to match curMana Speed over time 
        manaSlider.value = Mathf.Clamp01(curMana / maxMana);
   

      

    }
    private void ManageHealthBar()
    {
        if (curHealth <= 0 && healthFill.enabled)
        {
            healthFill.enabled = false;
        }
        else if (!healthFill.enabled && curHealth > 0)
        {
            Debug.Log("Revive");
            healthFill.enabled = enabled;
        }
        
    }
}
