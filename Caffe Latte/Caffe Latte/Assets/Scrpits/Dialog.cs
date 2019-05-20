using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog : MonoBehaviour


{

    private int index;
    private bool NoDialogo = false;


    public Text texto;
    public string[] sentences;   
    public float typingSpeed;
    public GameObject DialogPanel;
    public GameObject DialogBox;
    public Rigidbody2D Player;
    public AudioSource TelefoneDialogo;
    public AudioSource Music;



    public void StartDialog()
    {
        StartCoroutine(Type());
        DialogPanel.SetActive(true);
        DialogBox.SetActive(true);

        Player.constraints = RigidbodyConstraints2D.FreezeAll;

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && texto.text == sentences[index])
        {
            NextSentence();
        }
    }

    IEnumerator Type()
    {
        TelefoneDialogo.Play();
        foreach (char letter in sentences[index].ToCharArray())
        {
            texto.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        TelefoneDialogo.Pause();
       
    }

    public void NextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            texto.text = "";
            StartCoroutine(Type());

        }
        else
        {
            texto.text = "";
            DialogBox.SetActive(false);
            DialogPanel.SetActive(false);
            Player.constraints = RigidbodyConstraints2D.None;
            Player.constraints = RigidbodyConstraints2D.FreezeRotation;
            Music.Play();
        }
    }


}
