using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class componations : MonoBehaviour
{
    public bool ifBool;
    public int value;
    public int userValue;
    public int dice;
    public int dice1;
    public int dicepoints = 10;
    public int drakehp;
    public int spelare = 100;
    public int drakeattack;
    public int chancetohit;
    
        
    
    // Use this for initialization
    // i=inte lika med
    //==lika med
    // >större än
    // <mindre än
    // >= större eller lika med 
    //<= mindre eller lika med 
    // && och
    // ||eller 


    void Start()
    {
        chancetohit = Random.Range(0, 2);
        if (chancetohit == 0)//=miss 
        {
            drakeattack = 0;
        }
        else if (chancetohit == 2)//träf
        {
            
        }

        drakehp = Random.Range(100, 151);
        if (ifBool == true)
        {
            print("Ja");
        }
        else
        {
            print("Nej");
        }

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue = userValue + 2;

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue = userValue / 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("user Value");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            value = Random.Range(0, 10);
            print("du tryckte E");
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            dice = Random.Range(1, 7);
            dice1 = Random.Range(1, 7);
            dicepoints = dicepoints + dice;
            dicepoints = dicepoints - dice1;

            if (dicepoints >= 20)
            {
                print("Win");

            }
            if (dicepoints <= 0)
            {
                print("lose");

            }
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            
        }

    }
}


/*   if (value == 5)
   {
       if (ifBool == true)
       {
           print("hello");
       }
       else if (ifBool ==  (value ==4))
       {
           print("hi how are you");
       }
   }
       else if (value == 3)
       {
           print("hi");
       }

       }
   }
*/
