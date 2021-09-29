using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public float speed = 0.1f;

    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.parent != null)
        {
            this.transform.position = Vector3.Lerp(this.transform.position,
            this.transform.parent.position, speed * Time.deltaTime);

            this.transform.rotation = Quaternion.Lerp(
                this.transform.rotation,
                this.transform.parent.localRotation,
                speed * Time.deltaTime
            );
        }

        if (target != null)
        {
            //this.transform.LookAt(target);
        }

    }
}
