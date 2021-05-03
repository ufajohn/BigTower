using UnityEngine;

public class ExplodeCubes : MonoBehaviour
{
    private bool _collisionSet;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Cube" && !_collisionSet)
        {
            for(int i = collision.transform.childCount; i>=0; i--)
            {
                Transform child = collision.transform.GetChild(i);
                child.gameObject.AddComponent <Rigidbody> ();
                child.gameObject.GetComponent <Rigidbody> ().AddExplosionForce (70f, Vector3.up, 5f);
                child.SetParent(null);                
            }
            Destroy (collision.gameObject);
            _collisionSet = true;
        }
    }
}
