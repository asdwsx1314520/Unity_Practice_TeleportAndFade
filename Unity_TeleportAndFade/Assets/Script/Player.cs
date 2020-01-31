using UnityEngine;

public class Player : MonoBehaviour
{
    public SceneController sceneCont;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "傳送門")
        {
            sceneCont.NetLevel();
        }
    }
}
