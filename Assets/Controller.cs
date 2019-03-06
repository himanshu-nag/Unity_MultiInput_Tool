using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controller Class
/// </summary>
[RequireComponent(typeof(InputManager))]
public class Controller : MonoBehaviour
{
    /// <summary>
    /// Refrence to InputManager
    /// </summary>
    InputManager input;

	private void Awake()
	{
        input = GetComponent<InputManager>();
	}

    // Add your code below this bool condition => InputManager.Check("String(KeyBinding Command)") 
	void Update()
    {
        if (input.Check("Shoot"))
            gameObject.SetActive(false);
        if (input.Check("Jump"))
            gameObject.GetComponent<Renderer>().material.color = Color.red;
    }
}
