using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cat_logic : MonoBehaviour
{

    public float defeat_height;
    public GameManager game_game_manager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        heightLogic();
        
    }


    void heightLogic() 
    {
        if(transform.position.y <= defeat_height) 
        {
            game_game_manager.defeat();
        }
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ball")
        {
            game_game_manager.defeat();
        }

        else if (other.gameObject.tag == "robot")
        {
            Debug.Log("SUCESS" + other.gameObject.name);
            if(other.gameObject.TryGetComponent<robot_main>(out robot_main _robot)) 
            {
                _robot.spawn();
                Debug.Log(" SUP SUCESS" + other.gameObject.name);

            }
        }



    }


}
