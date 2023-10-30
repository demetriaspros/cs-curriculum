using System.Collections;
using System.Collections.Generic;
using System.Collections.Generic;
using Unity.Collections.LowLevel.Unsafe;
using TMPro;
using UnityEngine;

public class Hud : MonoBehaviour

{
    public TextMeshProUGUI coinsText;
    public TextMeshProUGUI healthText;
    
    public static Hud hud;
    public int coins;
    public int health;
    
    private void Awake()
    {
        if (hud != null && hud != this)
        {
            Destroy(gameObject);
        }
        else
        {
            hud = this;
            DontDestroyOnLoad(gameObject);
        }
            
    }
    // Start is called before the first frame update
    void Start()
    {
        hud.health = 5;
        hud.coins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        coinsText.text = "Coins: " + coins.ToString();
        healthText.text = "Health: " + health.ToString();
    }
}
