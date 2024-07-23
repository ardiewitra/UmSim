using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage4ObjectDetect : MonoBehaviour
{
    [SerializeField] private GameObject batas;
    [SerializeField] private Image image;
    // Start is called before the first frame update
    void Start()
    {
        batas.SetActive(true);
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
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
        yield return new WaitForSeconds(5f);
        image.enabled = false;
        Destroy(batas);
    }
}
