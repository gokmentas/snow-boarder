using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float delayTime = 0.5f;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Invoke("FinishLevel", delayTime);
        }
    }

    void FinishLevel()
    {
        SceneManager.LoadScene(0);
    }

} // class
