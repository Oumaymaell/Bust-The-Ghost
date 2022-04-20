using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProbabilityText : MonoBehaviour
{
    public Game clicked;
    public TextMeshPro probability;
    public double priorPropability = 0.006; 
     void BayesianProbability(int lastcheckedx, int lastcheckedy, int ghostx, int ghosty) 
    {  
        priorPropability= clicked.JointTableProbability("red", 0);
        
     }
    void Start()
    {
        clicked = FindObjectOfType(typeof(Game)) as Game;
        priorPropability= 0.006;
    }
    void Update()
    {   
        BayesianProbability(clicked.lastcheckedX, clicked.lastcheckedY, clicked.gx, clicked.gy);
        probability.text =  priorPropability.ToString();
    }
}
       
    