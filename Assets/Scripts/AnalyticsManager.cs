using UnityEngine;
using UnityEngine.Analytics;
using System.Collections;
using System.Collections.Generic;

public class AnalyticsManager : MonoBehaviour {

    public static AnalyticsManager instance;
    
	void Start () {
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

    public void SaveScoreOnAnalytics()
    {
        Analytics.CustomEvent("GameOver", new Dictionary<string, object>
        {
            { "Score", GameManager.instance.Score },
            { "HighScore", GameManager.instance.HighScore }
        });
    }
}
