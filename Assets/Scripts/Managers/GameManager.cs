using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public float time_now;
    public float time_max;
    public interface_manager game_interface_manager;
    // Start is called before the first frame update
    private void Awake()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Start()
    {
        time_now = time_max;   
    }

    // Update is called once per frame
    void Update()
    {
        time_now -= Time.deltaTime;
        if(time_now < 0) 
        {
            defeat();
        }
        game_interface_manager.UI_texts[0].text = time_now.ToString("0");
    }

    public void defeat() 
    {
        Cursor.lockState = CursorLockMode.None;
        Time.timeScale = 0f;
        game_interface_manager.OpenWindow(0);
        game_interface_manager.OpenButton(0);
    }

    public void restart() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        
    
    }

}
