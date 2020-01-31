using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class animLevel : MonoBehaviour
{
    public Animator anim;

    public AsyncOperation async;
    
    void Start()
    {
        anim.SetTrigger("int");
    }

    public void event_int(){}

    public void event_out()
    {
        async.allowSceneActivation = true;
    }
}
