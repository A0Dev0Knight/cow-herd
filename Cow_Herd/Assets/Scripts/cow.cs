using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow : MonoBehaviour
{
    [SerializeField] Transform TESTING;
    [SerializeField] private float healthPoints = 100;
    [SerializeField] private float cowSpeed = 2f;

    private float milkPoints = 0;

    Rigidbody cowRigidBody;
    void MoveCowTo(Transform target)
    {
        Vector3 direction = -(this.transform.position - target.position).normalized;
        cowRigidBody.MovePosition(this.transform.position + direction*cowSpeed*Time.deltaTime);    
    }
    // Start is called before the first frame update
    void Start()
    {
        cowRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCowTo(TESTING);

    }
    private void FixedUpdate()
    {

    }
}
