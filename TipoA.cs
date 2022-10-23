using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoA : MonoBehaviour
{
  public delegate void message();
  public message GROW_TYPE_B;
  public message STOP_GROWING_TYPE_B;
  public TipoB tipo_b;
  public TipoC tipo_c;
  private bool get_close = false;
  private Rigidbody rb;
  private Vector3 endPos;
  private Vector3 startPos;
  private Transform ownTransform;

  void Start()
  {
    tipo_b.GET_CLOSE += getting_close;
    tipo_b.STOP_GETTING_CLOSE += stop_getting_close;
    tipo_c.CHANGE_AND_JUMP += change_and_jump;
    rb = GetComponent<Rigidbody>();
    ownTransform = GetComponent<Transform>();
  }

  // Update is called once per frame
  void FixedUpdate()
  {
    if (get_close) {
      startPos = ownTransform.position;
      endPos = tipo_c.transform.position;
      rb.MovePosition(Vector3.Lerp(startPos, endPos, 0.1f));
    }
  }

  void getting_close() {
    get_close = true;
  }
  void stop_getting_close() {
    get_close = false;
  }
  void OnCollisionEnter(Collision other)
  {
    if (other.gameObject.tag == "Player") {
      GROW_TYPE_B();
    }
  }
  void OnCollisionExit(Collision other)
  {
    STOP_GROWING_TYPE_B();
  }
  
  void change_and_jump() {
    rb.AddForce(new Vector3(0,5,0), ForceMode.Impulse);
    gameObject.GetComponent<Renderer>().material.color = Random.ColorHSV();
  }
}
