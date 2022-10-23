using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
  public float speed = 7f;
  public int score = 0;
  private Rigidbody rb;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody>();
  }

  // Update is called once per frame
  void Update()
  {
    float aux = Time.deltaTime * speed;
    rb.AddForce(
      Input.GetAxis("Horizontal")*aux,
      0,
      Input.GetAxis("Vertical")*aux,
      ForceMode.VelocityChange
    );
  }
}
