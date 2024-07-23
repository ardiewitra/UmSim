using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InThawaf : MonoBehaviour
{
    [SerializeField] private GameObject batasHancur;
    [SerializeField] private GameObject batasBaru;
    // Start is called before the first frame update
    void Start()
    {
        batasHancur.SetActive(true);
        batasBaru.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //StartCoroutine(Wait());
            batasBaru.SetActive(true);
            Destroy(batasHancur);
        }
    }
}
