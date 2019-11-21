using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour
{
    // The button that will change to the first description scene
    private Button playButton;

    // Start is called before the first frame update
    void Start()
    {
        playButton = GetComponent<Button>();
        playButton.onClick.AddListener(delegate { MoveToNewScene(); });
    }

    private void MoveToNewScene()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
