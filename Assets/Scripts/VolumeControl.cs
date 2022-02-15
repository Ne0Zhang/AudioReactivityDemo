using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeControl : MonoBehaviour
{
    public Text message;
    public AudioSource music;

    public bool up, down;
    private float scale;

    private bool control = false;

    // Start is called before the first frame update
    void Start() {
        message.enabled = false;
        if (up) scale = 0.1f;
        else if (down) scale = -0.1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (control) {
            if(Input.GetKeyDown(KeyCode.Space)) {
                music.volume += scale;
            }
        }
    }

    void OnTriggerStay(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
            control = true;
			message.enabled = true;
		}
	}

    void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			control = false;
            message.enabled = false;
		}
	}
}
