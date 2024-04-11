using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float lifeTime = 5f;
    private Rigidbody _rigidbody;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.velocity = transform.forward * moveSpeed;
    }

    void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.CompareTag("TargetStanding"))
      {
         Debug.Log("I hit the standing target.");
         GameObject.Find("Game Manager").GetComponent<GameManager>().UpdateTargetAmount();
         Destroy(this.gameObject);
         other.gameObject.SetActive(false);
      }
      if(other.gameObject.CompareTag("TargetFloating"))
      {
         Debug.Log("I hit the floating target");
         GameObject.Find("Game Manager").GetComponent<GameManager>().UpdateTargetAmount();
         Destroy(this.gameObject);
         Destroy(other.gameObject);
      }
    }
}
