using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;
    State[] nextStates;
    public Button btn1, btn2;
  
    State state;
     
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        
        btn1.onClick.AddListener(ManageState1);
        btn2.onClick.AddListener(ManageState2);
        
        nextStates = state.GetNextStates();
    }

    private void ManageState1()
    {
        state = nextStates[0];

        textComponent.text = state.GetStateStory();

    }

    private void ManageState2()
    {
        state = nextStates[1];

        textComponent.text = state.GetStateStory();
    }
}
