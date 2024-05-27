using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private Vector3 targetPosition;
    private bool isMoving = false;

    void Update()
    {
        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Time.deltaTime * 5f);

            if (transform.position == targetPosition)
            {
                isMoving = false;
            }
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            float x = float.Parse(Input.inputString.Split(',')[0]);
            float z = float.Parse(Input.inputString.Split(',')[1]);
            
            targetPosition = new Vector3(x, transform.position.y, z);
            
            isMoving = true;
        }
    }
}