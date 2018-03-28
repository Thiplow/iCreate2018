using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Leap;

public class Utilisateur : MonoBehaviour
{

    // Boolean pour simplifier les if savoir s'il a une histoire déjà attrapée
    public bool audioSelected = false;
    // Son que l'utilisateur a attrapé (peut être nul s'il n'en a pas)
    public Leap.Unity.Sound son_selectionne;

    // Son de l'histoire
    public Leap.Unity.Sound Histoire_1;
    public Leap.Unity.Sound Histoire_2;
    public Leap.Unity.Sound Histoire_3;
    public Leap.Unity.Sound Histoire_4;
    public Leap.Unity.Sound Histoire_5;
    public Leap.Unity.Sound Histoire_6;

    // Son du bruitage
    public Leap.Unity.Sound Bruitage_1;
    public Leap.Unity.Sound Bruitage_2;
    public Leap.Unity.Sound Bruitage_3;
    public Leap.Unity.Sound Bruitage_4;
    public Leap.Unity.Sound Bruitage_5;
    public Leap.Unity.Sound Bruitage_6;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        // Longue liste de if pour savoir si un mouvement est fait ou non
        
    }
}
