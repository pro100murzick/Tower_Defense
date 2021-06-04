using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender_Button : MonoBehaviour
{

    [SerializeField] Defender defenderPrefab;
    Defender_Button[] buttons;
    private void OnMouseDown()
    {
        TurnOffButtons(buttons);
        GetComponent<SpriteRenderer>().color = Color.white;
        FindObjectOfType<Defender_Spawner>().SetSelectedDefender(defenderPrefab);
    }

    private void TurnOffButtons(Defender_Button[] buttons)
    {
        foreach (Defender_Button button in buttons)
        {
            button.GetComponent<SpriteRenderer>().color = new Color32(105, 105, 105, 255);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        buttons = FindObjectsOfType<Defender_Button>();
        TurnOffButtons(buttons);
    }

}
