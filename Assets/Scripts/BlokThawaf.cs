using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlokThawaf : MonoBehaviour
{
    [SerializeField] private Image image;
    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(Wait());
        }
    }

    IEnumerator Wait()
    {
        image.enabled = true;
        yield return new WaitForSeconds(3f);
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
