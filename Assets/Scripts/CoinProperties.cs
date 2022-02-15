using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinProperties : MonoBehaviour
{
    private float spinSpeed = 5f;

    void Start(){
    }

    // Update is called once per frame
    void Update()
    {
        CoinAnimation();
        this.transform.localScale = new Vector3((AudioPeer._samples[2] * 2000) + 20, (AudioPeer._samples[2] * 2000) + 20, (AudioPeer._samples[2] * 2000) + 20);

    }

    void CoinAnimation() {
        transform.Rotate(new Vector3(0, 30, 0) * spinSpeed * Time.deltaTime);
    }
}
