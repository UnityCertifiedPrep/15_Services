using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;


public class AdScript : MonoBehaviour {

    bool hasShownAdd = false;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        if (!hasShownAdd)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show();
                hasShownAdd = true;
            }
        }
    }
}
