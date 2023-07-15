using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerPoint : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    //private AudioSource _audio;

    private void Awake()
    {
        //_audio = GetComponent<AudioSource>();
        _text.text = Score.totalScore.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collectable"))
        {
            //_audio.Play();
            Destroy(other.gameObject);
            Score.totalScore++;
            _text.text = Score.totalScore.ToString();
        }
    }
}
