using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Stage5TransisiScene : MonoBehaviour
{
    [SerializeField] private Image image;
    [SerializeField] private Image image2;
    // Start is called before the first frame update
    void Start()
    {
        image.enabled = false;
        image2.enabled = false;
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
        image2.enabled = true;
        yield return new WaitForSeconds(10f);
        image.enabled = false;
        image2.enabled = false;
        SceneManager.LoadScene("Menu Utama");
    }
}
