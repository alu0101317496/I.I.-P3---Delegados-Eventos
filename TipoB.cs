using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TipoB : MonoBehaviour
{
  public delegate void message();
  public event message GET_CLOSE;
  public event message STOP_GETTING_CLOSE;
  public TipoA tipo_a;
  public TipoC tipo_c;
  private bool grow = false;
  private Vector3 scale_change = new Vector3(0.01f, 0.01f, 0.01f);
  private Vector3 default_scale = new Vector3(1f,1f,1f);
  // Start is called before the first frame update
  void Start()
  {
    tipo_a.GROW_TYPE_B += StartGrow;
    tipo_a.STOP_GROWING_TYPE_B += StopGrow;
    tipo_c.CHANGE_AND_JUMP += look_at_c;
  }
  // Update is called once per frame
  void Update() 
  {
    if (grow) {
      transform.localScale += scale_change;
    } else if (
        !grow && 
        transform.localScale.x > 1f &&
        transform.localScale.y > 1f &&
        transform.localScale.z > 1f) {
      transform.localScale -= scale_change;
    }
  }
  void OnTriggerEnter(Collider other)
  {
    if (other.tag == "Player") {
      GET_CLOSE();
    } else {
      STOP_GETTING_CLOSE();
    }
  }
  // TODO: Manage
  void OnTriggerExit(Collider other)
  {
      STOP_GETTING_CLOSE();
  }
  void StartGrow() { grow = true; }
  void StopGrow() { grow = false; }
  void look_at_c() {
    transform.LookAt(tipo_c.transform.position);
    Debug.DrawRay(transform.position, tipo_c.transform.position, Color.green, 100);
  }
}
