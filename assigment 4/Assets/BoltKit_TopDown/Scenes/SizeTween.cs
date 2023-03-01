using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SizeTween : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        LeanTween.scale(gameObject, new Vector3(5.65f, 1.9f, 1f), 2f).setDelay(3);
        LeanTween.moveLocal(gameObject, new Vector3(5.65f,0,0),2f).setDelay(3);

        yield return new WaitForSeconds(6);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
