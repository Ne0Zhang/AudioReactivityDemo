using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JukeBox : MonoBehaviour
{
    public List<AudioClip> _audio;
    public TextMesh SongName;

    private int select;
    private bool control = false;

    // Start is called before the first frame update
    void Start()
    {
        select =  Random.Range(0,_audio.Count);
        SongName.text = _audio[select].name;
        this.GetComponent<AudioSource>().clip = _audio[select];
        this.GetComponent<AudioSource>().Play();
    }

    // Update is called once per frame
    void Update()
    {
        ChangeMusic();
    }

    void OnTriggerStay(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
            control = true;
		}
	}

    void OnTriggerExit(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			control = false;
		}
	}

    void ChangeMusic() {
        if (control) {
            if(Input.GetKeyDown(KeyCode.Space)) {
                if (select >= _audio.Count - 1) select = 0;
                else select++;
                this.GetComponent<AudioSource>().clip = _audio[select];
                SongName.text = _audio[select].name;
                this.GetComponent<AudioSource>().Play();
            }
        }
    }
}
