/**
* Handels the Camera stuff
*
* @author Flavio Kleiber
* @copyright (c) 2015 PiratesAndChees Studios 
*/
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform cameraTarget;
    public float minViewDistance = 10;
    public float maxViewDistance = 25;
    public int zoomRate = 30;
    private int lerpRate = 5;
    private int cameraTargetHeight = 1; //Scale of the model
    private float x = 0.0f;
    private float y = 0.0f;
    private int mouseXSpeedMod = 5;
    private int mouseYSpeedMod = 5;
    private float distance = 3;
    private float desiredDistance;
    private float correctedDistance;
    private float currentDistance;

    // Use this for initialization
    void Start () {
        Vector3 angles = transform.eulerAngles;
        x = angles.x;
        y = angles.y;
        desiredDistance = distance;
        correctedDistance = distance;
        currentDistance = distance;
    }
	

	void LateUpdate () {

        if (Input.GetMouseButton(1)) {
            x += Input.GetAxis("Mouse X") * mouseXSpeedMod;
            y -= Input.GetAxis("Mouse Y") * mouseYSpeedMod;
        } else if (Input.GetAxis("Vertical") != 0 || Input.GetAxis("Horizontal") != 0) {
            float targetRotationAngle = cameraTarget.eulerAngles.y;
            float cameraRotationAngle = transform.eulerAngles.y;
            x = Mathf.LerpAngle(cameraRotationAngle, targetRotationAngle, lerpRate * Time.deltaTime);
        }

        y = clampAngle(y, -50, 80);
        Quaternion rotation = Quaternion.Euler(y, x, 0);
        desiredDistance -= Input.GetAxis("Mouse ScrollWheel") * Time.deltaTime * zoomRate * Mathf.Abs(desiredDistance);
        desiredDistance = Mathf.Clamp(desiredDistance, minViewDistance, maxViewDistance);
        correctedDistance = desiredDistance;
        Vector3 pos = cameraTarget.position - (rotation * Vector3.forward * correctedDistance);

        RaycastHit collisionHit;
        Vector3 cameraTaregtPosition = new Vector3(cameraTarget.position.x, cameraTarget.position.y + cameraTargetHeight, cameraTarget.position.z);

        bool isCorrected = false;
        if (Physics.Linecast(cameraTaregtPosition, pos, out collisionHit)) {
            pos = collisionHit.point;
            correctedDistance = Vector3.Distance(cameraTaregtPosition, pos);
            isCorrected = true;
        }

        currentDistance = !isCorrected || correctedDistance > currentDistance ? Mathf.Lerp(currentDistance, correctedDistance, Time.deltaTime * zoomRate) : correctedDistance;
        pos = cameraTarget.position - (rotation * Vector3.forward * currentDistance + new Vector3(0, -cameraTargetHeight, 0));
        transform.rotation = rotation;
        transform.position = pos;

    }

    private static float clampAngle(float angle, float min, float max) {

        if (angle < -360) {
            angle += 360;
        }

        if (angle > 360) {
            angle -= 360;
        }

        return Mathf.Clamp(angle, min, max);

    }
}
