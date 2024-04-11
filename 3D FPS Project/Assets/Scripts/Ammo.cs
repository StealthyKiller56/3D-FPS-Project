using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ammo : MonoBehaviour
{
    public TextMeshProUGUI ammoAmountText;
    private int _ammoAmount = 10;

    // Start is called before the first frame update
    void Start()
    {
       DisplayAmmoAmount();
    }

    public void RemoveAmmo()
    {
        _ammoAmount -= 1;
        DisplayAmmoAmount();
    }
    public void AddAmmo()
    {
        _ammoAmount += 10;
        DisplayAmmoAmount();
    }
    public void DisplayAmmoAmount()
    {
        ammoAmountText.text = _ammoAmount.ToString();
    }
    public int GetAmmoAmount()
    {
       return _ammoAmount;
    }
}
