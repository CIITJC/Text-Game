using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using TMPro;

public class script : MonoBehaviour
{

    public GameObject scene_1, scene_2, scene_3;
    public GameObject stats;
    public TextMeshProUGUI healthValue, sanityValue;
    public int healthpoints, sanitypoints;

    public GameObject[] Scenes;
    public int ActiveScene;
    // Start is called before the first frame update
    void Start()
    {
        Scenes[0].SetActive(true);
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneChnager()
    {
        ActiveScene = 1
        Scenes[1].SetActive(true);
        for (int i = 0; i < Scenes.Length; i++)
        {
            Scenes[i].SetActive(i == ActiveScene);
        }
    }
    public void StartButton()
    {
        //scene_1.SetActive(false);
        //scene_2.SetActive(true);
        //stats.SetActive(true);
        ActiveScene = 1 
        Scenes[1].SetActive(true);
        for (int i = 0; i < Scenes.Length; i ++)
        {
            Scenes[i].SetActive(i == ActiveScene);
        }
    }
}   
