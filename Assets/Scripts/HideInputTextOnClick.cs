using UnityEngine;
using TMPro;

public class HideInputTextOnClick : MonoBehaviour
{
    TMP_Text tmptext;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tmptext = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        tmptext.enabled = !Input.GetMouseButton(0);
    }
}
