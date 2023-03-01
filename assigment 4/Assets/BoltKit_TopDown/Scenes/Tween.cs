using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Tween : MonoBehaviour
{
    // Start is called before the first frame update
    bool Debouce = false;
    public AudioSource audioData;
    public AudioSource audioData2;
    public AudioSource audioData3;


    public void Start()
    {
        StartCoroutine(Tweener());

    }

    // Update is called once per frame
    public IEnumerator Tweener()
    {
        while (true)
        {
            if (!Debouce)
            {
                Debouce = true;
                float AudioChooser = Random.Range(1f, 3f);
                Debug.Log($"s{AudioChooser}");
                if (AudioChooser <=1f)
                {
                    audioData.Play(0);
                }
                else if (AudioChooser >1 && AudioChooser <=2)
                {
                    audioData2.Play(0);

                }
                else if (AudioChooser >2 && AudioChooser <=3)
                {
                    audioData3.Play(0);

                }

                float ticks = Random.Range(3f, 6f);
      
                for (int i = 0; i < ticks; i++)
                {
                    float randomNumber = Random.Range(0f, 10f);
                    float X = Random.Range(200f, 400f);
                    float Y = Random.Range(-50f, 5f);

                    float waiter = Random.Range(10f / 100, 20f / 100);



                    LeanTween.moveLocal(gameObject, new Vector3(X, Y, 0f), 0f).setDelay(randomNumber);
                    LeanTween.color(gameObject, Color.red, 0f);

                    yield return new WaitForSeconds(waiter);
                    LeanTween.color(gameObject, Color.red, 0f);

                    LeanTween.moveLocal(gameObject, new Vector3(transform.position.x, transform.position.y, 0f), 0f).setDelay(randomNumber);
                    yield return new WaitForSeconds(waiter);
                    LeanTween.color(gameObject, Color.blue, 0f);
                    yield return new WaitForSeconds(0.1f);
                    LeanTween.color(gameObject, Color.green, 0f);
                    yield return new WaitForSeconds(0.1f);
                    LeanTween.color(gameObject, Color.red, 0f);
                    yield return new WaitForSeconds(0.1f);
                    LeanTween.color(gameObject, Color.white, 0f);
                }

                LeanTween.color(gameObject, Color.white, 0f);

                yield return new WaitForSeconds(ticks/2 + 1.5f);

                Debouce = false; 
            }

        }
    }
}