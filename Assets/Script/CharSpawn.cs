using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharSpawn : MonoBehaviour
{

    public GameObject[] character;
    public GameObject[] boss;
    public bool Spawn;
    public Click scriptClick;
    public  GameObject car;

    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {

        
            if (Click.spawn)
            {
                if (car != null) {
                    Destroy(car);
                    /*if (Click.jujui == 2)
                    {
                        Click.selesai = false;
                    }*/
                    
                }
            if (Click.bossbattle == "true")
            {
                if (Click.level % 10 == 0)
                {
                    car = Instantiate(boss[1], new Vector2(transform.position.x, transform.position.y + 0f), Quaternion.identity);
                    Click.spawn = false;
                    Click.jujui = 1;
                    Debug.Log("boss");
                }
                else
                {
                    car = Instantiate(boss[0], new Vector2(transform.position.x, transform.position.y + 0f), Quaternion.identity);
                    Click.spawn = false;
                    Click.jujui = 1;
                    Debug.Log("boss");
                }
            }
            else {
                car = Instantiate(character[Random.Range(0, character.Length)], new Vector2(transform.position.x, transform.position.y + 0f), Quaternion.identity);
                Click.spawn = false;
                Click.jujui = 1;
                Debug.Log("spawn");
            }
                
            }

        }
   }

