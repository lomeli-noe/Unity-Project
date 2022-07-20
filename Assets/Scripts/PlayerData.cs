using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerData : MonoBehaviour
{
    private string name;
    
    public void ReadString(string s)
    {
        name = s;
        Debug.Log("name: " + name);
    }
}
