using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create512Cubes : MonoBehaviour
{
    public GameObject _sampleCubePrefab;
    GameObject[] _sampleCube = new GameObject[512];
    private float _maxScale = 2500;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 512; i++) {
            GameObject _instanceSampleCube = Instantiate<GameObject>(_sampleCubePrefab);
            _instanceSampleCube.transform.position = this.transform.position;
            _instanceSampleCube.transform.parent = this.transform;
            _instanceSampleCube.name = "SampleCube" + i;
            this.transform.eulerAngles = new Vector3 (8, -0.703125f * i, 0);
            _instanceSampleCube.transform.position = Vector3.forward * 100;
            _sampleCube[i] = _instanceSampleCube;
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 512; i++) {
            if (_sampleCube != null) {
                _sampleCube[i].transform.localScale = new Vector3(1, (AudioPeer._samples[i] * _maxScale) + 2, 1);
            }
        }
    }
}
