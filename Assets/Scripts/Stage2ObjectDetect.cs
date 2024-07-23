using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2ObjectDetect : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Image image2;
    [SerializeField] private GameObject batas;
    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
        image2.enabled = false;
        batas.SetActive(false);
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
        yield return new WaitForSeconds(3f);
        image.enabled = false;
        batas.SetActive(true);
        image2.enabled = true;
        yield return new WaitForSeconds(7f);
        image2.enabled = false;
        Destroy(this.gameObject);

    }
}
