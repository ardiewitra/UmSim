using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoWalkVR : MonoBehaviour
{
    private const int RIGHT_ANGLE = 90; 
    private bool isWalking = false;
    Transform mainCamera = null;
    private float speed = 6f;
    private bool walkWhenLookDown = true;
    private double thresholdAngle = 30;
    AudioSource audiosrc;

    void Start()
    {
        mainCamera = Camera.main.transform;
        audiosrc = GetComponent<AudioSource>();
    }

    void Update()
    {
        // Walk when player looks below the threshold angle 
        if (walkWhenLookDown && !isWalking &&
            mainCamera.transform.eulerAngles.x >= thresholdAngle &&
            mainCamera.transform.eulerAngles.x <= RIGHT_ANGLE)
        {
            isWalking = true;
            AudioPlay();
        }
        else if (walkWhenLookDown && isWalking &&
                 (mainCamera.transform.eulerAngles.x <= thresholdAngle ||
                 mainCamera.transform.eulerAngles.x >= RIGHT_ANGLE))
        {   
            isWalking = false;
            AudioPlay();
        }

        if (isWalking)
        {
            Vector3 direction = new Vector3(mainCamera.transform.forward.x, 0, mainCamera.transform.forward.z).normalized * speed * Time.deltaTime;
            Quaternion rotation = Quaternion.Euler(new Vector3(0, -transform.rotation.eulerAngles.y, 0));
            transform.Translate(rotation * direction);
        }
    }

    private void AudioPlay()
    {
        if (!audiosrc.isPlaying)
        {
            if (isWalking)
            {
                audiosrc.Play();
                audiosrc.loop = true;
            }
            else if (!isWalking)
            {
                audiosrc.Stop();
                audiosrc.loop = false;
            }
        }
        else if (audiosrc.isPlaying)
        {
            if (!isWalking)
            {
                audiosrc.Stop();
                audiosrc.loop = false;
            }
        }
    }


}
