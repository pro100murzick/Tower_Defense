using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender_Button : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;

    private void OnMouseDown()
    {
        Defender_Button[] buttons = FindObjectsOfType<Defender_Button>();
        foreach (Defender_Button button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(105, 105, 105, 255);
        }
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<Defender_Spawner>().SetSelectedDefender(defenderPrefab);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

}
