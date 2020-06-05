using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class levelloader : MonoBehaviour {

    public GameObject loadingScreen;
    public Slider slider;
	void Start()
    {
        StartCoroutine(loadsyn("NoteRide"));
    }

	IEnumerator loadsyn (string sceneindex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneindex);
        loadingScreen.SetActive(true);

        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }
    }
}
