using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinFunction : MonoBehaviour
{
    //public GameObject detector;
    public Transform enemy;
    private float magnitude = 1;
    public float enemyDist = 10.0f;
    public float detectorspeed = 1;



    void Update()
    {
        if (GameManager.instance.mazeAgentGO != null)
            enemyDist = Vector3.Distance(GameManager.instance.mazeAgentGO.transform.position, transform.position);
        
        Color detectorColor = new Color(1.0f, SineAmount(), SineAmount(), 1.0f);
        var detectorRenderer = GetComponent<Renderer>();
        
        detectorRenderer.material.SetColor("_Color", detectorColor);
    }

    public float SineAmount()
    {
        return magnitude * Mathf.Sin(Time.time * 1 / enemyDist * 100 * detectorspeed);
    }

}
