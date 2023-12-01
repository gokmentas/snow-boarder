using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;
    [SerializeField] ParticleSystem finishEffect;
    bool shouldCollide = true;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && shouldCollide)
        {
            shouldCollide = false;
            finishEffect.Play();
            GetComponent<AudioSource>().Play();
            Invoke("FinishLevel", delayTime);
        }
    }

    void FinishLevel()
    {
        SceneManager.LoadScene(0);
    }

} // class
