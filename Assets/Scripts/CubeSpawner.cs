using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private Cube _cubePref;
    [SerializeField] private TMP_InputField _field;
    
    public void SpawnNCubes()
    {
        var n = 0;
        if (_field.text == null || !int.TryParse(_field.text, out n)) return;
        for (var i = 0; i < n; i++)
        {
            Instantiate(_cubePref, gameObject.transform);
        }
    }
}
