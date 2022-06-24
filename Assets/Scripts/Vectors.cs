using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Transform newPosition;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TargetPositionRoutine(newPosition));
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Vector3.Distance(transform.position, newPosition.position) > 0.05f)
    //    {
    //        Debug.Log("Distance is: " + Vector3.Distance(transform.position, newPosition.position));
    //        transform.position = Vector3.Lerp(transform.position, newPosition.position, speed * Time.deltaTime);
    //    }
    //}

    IEnumerator TargetPositionRoutine(Transform target)
    {
        while (Vector3.Distance(transform.position, newPosition.position) > 0.05f)
        {
            Debug.Log("Distance is: " + Vector3.Distance(transform.position, newPosition.position));
            transform.position = Vector3.Lerp(transform.position, newPosition.position, speed * Time.deltaTime);

            yield return null;
        }

        Debug.LogWarning("Player has gotten to target");

        yield return new WaitForSeconds(2f);

        Debug.LogWarning("Coroutine has finished");
    }
}
