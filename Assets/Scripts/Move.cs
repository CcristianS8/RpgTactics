using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float speed;
    private Vector3 movePoint;
    [SerializeField] private Vector3 offsetMovePoint;
    [SerializeField] private LayerMask obstacule;
    [SerializeField] private float circleRadius;
    private bool movement = false;
    private Vector3 input;

    // Start is called before the first frame update
    void Start()
    {
        movePoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("Vertical");
        input.y = Input.GetAxis("Horizontal");

        if (movement)
        {
            transform.position = Vector3.MoveTowards(transform.position, movePoint, speed * Time.deltaTime);

            if(Vector3.Distance(transform.position, movePoint) == 0)
            {
                movement = false;
            }
        }

        if ((input.x != 0 ^ input.y != 0) && !movement)
        {
            Vector3 pointCondition = new Vector3(transform.position.x, transform.position.y) + offsetMovePoint + input;

            if(!Physics2D.OverlapCircle(pointCondition, circleRadius, obstacule))
            {
                movement = true;
                movePoint += input;
            }
        }
    }

    private void OnDrawGizmos() 
    {  
       Gizmos.color = Color.yellow;
       Gizmos.DrawWireSphere(movePoint + offsetMovePoint, circleRadius); 
    }
}
