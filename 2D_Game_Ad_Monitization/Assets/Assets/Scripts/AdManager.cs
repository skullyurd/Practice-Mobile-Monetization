using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdManager : MonoBehaviour
{
#if UNITY_IOS
    private string gameId = "4560914";

#elif UNITY_ANDROID
    private string gameId = "4560915";

#elif UNITY_EDITOR
    private string gameID = "4560915";
#endif

    private string placementId = "ClickReward";

    public static AdManager instance;

    private void Awake()
    {
        
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        //Advertisement.Initialize(gameID, true);
    }
}
