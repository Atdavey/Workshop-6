using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    [SerializeField] Button button;
    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(Load);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Load(){
        SceneManager.LoadScene("MainScene");
    }
}
