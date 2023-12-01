using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool shouldTrigger = true;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground") && shouldTrigger)
        {
            shouldTrigger = false;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("GameOver", delayTime);
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(0);
    }

} // class
