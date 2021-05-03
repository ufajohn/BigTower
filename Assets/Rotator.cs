
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private float _speed = 5f;
    public Transform _rotator;

    // Start is called before the first frame update
    private void Start()
    {
        _rotator = GetComponent<Transform>();
     

    }

    // Update is called once per frame
    private void Update()
    {
        _rotator.Rotate(0, _speed * Time.deltaTime , 0);
    }
}
