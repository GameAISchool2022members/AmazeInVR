using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class changeText : MonoBehaviour 
{
    public Transform enemy;
    public float enemyDist = 10.0f;

    [SerializeField] private TextMeshProUGUI myTextElement;
    
    void Update() 
    {
        if(GameManager.instance.mazeAgentGO != null)
            enemyDist = Vector3.Distance(GameManager.instance.mazeAgentGO.transform.position, transform.position);
        ButtonPress();
    }

    public void ButtonPress()
    {
        myTextElement.text = Mathf.Round(enemyDist * 100f) / 100f + "m";
    }
}
