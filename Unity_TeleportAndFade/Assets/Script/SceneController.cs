using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{
    public animLevel anim;

    public void NetLevel()
    {
        anim.async = SceneManager.LoadSceneAsync("第二關");

        anim.async.allowSceneActivation = false;

        anim.anim.SetTrigger("out");
    }
}
