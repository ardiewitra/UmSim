﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage5Starter : MonoBehaviour
{
    [SerializeField] private Image image;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        image.enabled = true;
        yield return new WaitForSeconds(12f);
        image.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
