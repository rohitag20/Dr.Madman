using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    public int points = 0;
    public int flask = 2;

    

    public GUIStyle guistyle = new GUIStyle();

    public GUIStyle guistyle2 = new GUIStyle();
    
    void OnGUI(){

        guistyle.fontSize = 80;
        guistyle.fontStyle = FontStyle.Bold;
        guistyle.normal.textColor = Color.white;

        guistyle2.fontSize = 80;
        guistyle2.fontStyle = FontStyle.Bold;
        guistyle2.normal.textColor = Color.red;   

        

        GUI.Label(new Rect(150,50,200,40), "Score: " + (points * 10),guistyle);

        GUI.Label(new Rect(2500,50,200,40), "You need to get " + flask + " flask(s)",guistyle2);

        
    }
}
