using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject dataBoard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(4);
    }
    
    

    public void XButton()
    {
        dataBoard.SetActive(false);
    }
}
