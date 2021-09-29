using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ControlMode {
    _2D,
    _3D
}
public class CharacterMovement : MonoBehaviour
{

    public ControlMode mode = ControlMode._2D;

    public Transform camera;
    public Transform _2dCamHolder, _3dCamHolder;

    public float speed = 8;

    public float jumpForce = 10;

    public Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        camera.transform.SetParent(_2dCamHolder);
        rigidBody = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (mode == ControlMode._2D)
        {
            if (Input.GetKey(KeyCode.D))
            {
                this.transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                this.transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
            }
            camera.GetComponent<Camera>().orthographic = true;
            camera.GetComponent<Camera>().orthographicSize = 10.0f;

            if (Input.GetKeyDown(KeyCode.Tab))
            {
                camera.transform.SetParent(_3dCamHolder);
                
                mode = ControlMode._3D;
            }
            
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rigidBody.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);

            }
        }
        else
        {
            if (Input.GetKey(KeyCode.W))
            {
                this.transform.position += new Vector3(1, 0, 0) * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                this.transform.position -= new Vector3(1, 0, 0) * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                this.transform.position -= new Vector3(0, 0, 1) * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                this.transform.position += new Vector3(0, 0, 1) * speed * Time.deltaTime;
            }
            camera.GetComponent<Camera>().orthographic = true;
            camera.GetComponent<Camera>().orthographicSize = 10.0f;

            if (Input.GetKeyDown(KeyCode.Tab))
            {
                camera.transform.SetParent(_2dCamHolder);
                
                mode = ControlMode._2D;
            }

        }


        
    }
}
