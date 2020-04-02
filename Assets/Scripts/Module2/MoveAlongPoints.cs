using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAlongPoints : CustomComponent
{
    public GameObject[] destinationPoints;
    public int currentDestinationIndex = 0;
    public float speed = 5;
    public float rotationSpeed = 30f;

    void Update()
    {
        GameObject targetObject = destinationPoints[currentDestinationIndex];
        Vector3 relativePos = targetObject.transform.position - gameObject.transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(relativePos, transform.up);
        gameObject.transform.rotation = Quaternion.Lerp(gameObject.transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        gameObject.transform.position += transform.forward * speed * Time.deltaTime;
        Vector3 distance = gameObject.transform.position - targetObject.transform.position;
        float dist = distance.magnitude;

        // Emeka Added this Code
        int destiPLen = destinationPoints.Length - 1;
        bool enableReplace = true;


        new MoveAlongTest().checkLogic(dist, currentDestinationIndex, destiPLen, enableReplace);


        /*if (dist < 0.5)
        {
            /*Formal code here
             if(currentDestinationIndex < destinationPoints.Length - 1)#1#
            if (currentDestinationIndex < destiPLen)
                currentDestinationIndex++;
            else
                //enabled = false;
                enableReplace = false;
        }*/
        // Emeka Added this code
        enabled = enableReplace;
    }
}
public class MoveAlongTest
{
    public int testCurrentDestIndeex = 0;
    public bool testEnabled = true;
    public void checkLogic(float dist, int currentDestinationIndex, int destiPLen, bool enableReplace)
    {
        if (dist < 0.5)
        {
            /*Formal code here
             if(currentDestinationIndex < destinationPoints.Length - 1)*/
            if (currentDestinationIndex < destiPLen)
            {
                currentDestinationIndex++;
                testCurrentDestIndeex = currentDestinationIndex;
            }
            else
            {
                //enabled = false;
                enableReplace = false;
                testEnabled = enableReplace;
            }
        }
    }
}