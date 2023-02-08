using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Store : MonoBehaviour
{
    public GameObject ObjectText;
    public bool IsPlayerNear = false;
    public string TextInput;

    // Start is called before the first frame update
    void Start()
    {
        ObjectText.transform.GetChild(1).GetComponent<TMP_Text>().text = TextInput;
    }

    // Update is called once per frame
    void Update()
    {
        ObjectText.SetActive(IsPlayerNear);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsPlayerNear = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            IsPlayerNear = false;
        }
    }
}
