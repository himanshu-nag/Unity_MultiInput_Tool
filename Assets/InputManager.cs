using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
    /// <summary>
    /// List for keybinding
    /// </summary>
    [SerializeField]
    public List<Keys> keyBindings;

    /// <summary>
    /// To store key and input name as a databse.
    /// </summary>
    private Dictionary<string, KeyCode> keyDatabase;

    private void Awake()
    {
        keyDatabase = new Dictionary<string, KeyCode>(keyBindings.Count);
        for (int i = 0; i < keyBindings.Count; i++)
        {
            if (string.IsNullOrEmpty(keyBindings[i].Name))
                throw new Exception("Please check all the assigned names and keys in InputManager script."); 
            keyDatabase.Add(keyBindings[i].Name, keyBindings[i].keyCode);
        }
    }

    /// <summary>
    /// returns true if key is pressed for specific input.
    /// </summary>
    /// <returns>bool</returns>
    /// <param name="inputName">Input name in key binding</param>
    public bool Check(string inputName)
    {
        if (!keyDatabase.ContainsKey(inputName))
            return false;
        if (Input.GetKeyDown(keyDatabase[inputName]))
        {
            return true;
        }
        return false;
    }
}

/// <summary>
/// Key class
/// </summary>
[System.Serializable]
public class Keys
{
    public string Name;
    public KeyCode keyCode;
}
