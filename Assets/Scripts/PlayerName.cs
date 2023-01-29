using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{

    public InputField myName;
    public Text nameValue;

    void Update()
    {
	nameValue.text = myName.text;
    }
}
