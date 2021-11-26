using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CoinsCounter : MonoBehaviour
{
    public float Coins;

    public Text coinstext;

    public void AddCoin(){

        Coins++;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       coinstext.text = Coins.ToString(); 
    }
}
