using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoC : MonoBehaviour
{
  public delegate void message();
  public message CHANGE_AND_JUMP;

  private Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
      
  }

  void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "Player") {
      CHANGE_AND_JUMP();
    }
  }
}
