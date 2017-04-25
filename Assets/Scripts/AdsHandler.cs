using UnityEngine;
using UnityEngine.Advertisements;

public class AdsHandler : MonoBehaviour
{

    public static AdsHandler instance;

    void Start()
    {
        if (!instance)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void ShowAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }

    public bool isShowing()
    {
        return Advertisement.isShowing;
    }
}
