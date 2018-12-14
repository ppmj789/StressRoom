using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void ChangeGameScene01()
    {
        SceneManager.LoadScene("Stage 1");
    }

    public void ChangeGameScene02()
    {
        SceneManager.LoadScene("Stage 2");
    }

    public void ChangeGameScene03()
    {
        SceneManager.LoadScene("Stage 3");
    }

    public void ChangeGameSceneEnd()
    {
        SceneManager.LoadScene("End");
    }
}
