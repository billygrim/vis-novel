using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace OurGame
{
    public class SceneManager : MonoBehaviour
    {
        public Button changeScene;
        public string sceneName;

        private void Start()
        {
            changeScene.onClick.AddListener(LoadNewScene);
        }

        private void LoadNewScene()
        {
            FindObjectOfType<SceneFader>().In();
            Invoke("DelayedSceneLoad", 1);
        }

        void DelayedSceneLoad()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
        }
    }
}