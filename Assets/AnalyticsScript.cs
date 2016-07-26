﻿using UnityEngine;
using System.Collections.Generic;
using UnityEngine.Analytics;

public class AnalyticsScript : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Gender gender = Gender.Female;

        Analytics.SetUserGender(gender);

        int birthYear = 2014;
        Analytics.SetUserBirthYear(birthYear);

        int totalPotions = 5;
        int totalCoins = 100;
        string weaponID = "Weapon_102";
        Analytics.CustomEvent("gameOver", new Dictionary<string, object>
          {
            { "potions", totalPotions },
            { "coins", totalCoins },
            { "activeWeapon", weaponID }
          });
        Analytics.Transaction("12345abcde", 0.99m, "USD", null, null);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
