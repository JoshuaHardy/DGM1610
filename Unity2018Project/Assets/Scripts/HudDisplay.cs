using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HudDisplay : MonoBehaviour
{
    public Text textbox;
   // public float
    // Start is called before the first frame update
    void Start()
    {
        textbox = GetComponent<Text>();
 
    }

    // Update is called once per frame
    void Update()
    {
//        textbox.text = "Test"; 
                       //+ health;
 
       // if(health <= 0)
       //     Destroy(gameObject);
    }
}
