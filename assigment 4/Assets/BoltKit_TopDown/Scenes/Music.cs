using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource SoundOne;
    public AudioSource SoundTwo;
    public AudioSource SoundThree;
    public AudioSource SoundFour;
    public AudioSource SoundFive;
    // Start is called before the first frame update
    public void Start()
    {

 



        int numb = Random.Range(1, 5);
        Debug.Log(numb);
        switch (numb)
        {
            case 1:
                SoundOne.Play();
                break;
            case 2:
                SoundTwo.Play();

                break;
            case 3:
                SoundThree.Play();

                break;
            case 4:
                SoundFour.Play();

                break;
            case 5:
                SoundFive.Play();

                break;

        }

        // Update is called once per frame

   }
}
