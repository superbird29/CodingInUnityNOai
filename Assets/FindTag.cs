using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class FindTag : MonoBehaviour
{
    List<GameObject> AnchorPoints;

    public ShapesNamesDataStrut Info = new ShapesNamesDataStrut();

    public void ButtonClick()
    {
        AnchorPoints = GameObject.FindGameObjectsWithTag("Anchor").ToList();
        //find them in order
        //then
        //place the gameobject and the text there
        for(int i = 0; i < AnchorPoints.Count; i++)
        {
            Instantiate(Info.Shape, AnchorPoints[i].transform);
            AnchorPoints[i].GetComponentInChildren<TMP_Text>().text = Info.Greeting;
        }
    }
}
