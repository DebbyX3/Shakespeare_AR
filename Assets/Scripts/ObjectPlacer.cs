using UnityEngine;

public class ObjectPlacer : MonoBehaviour
{
    [SerializeField]
    private GameObject objectToPlace;

    public void PlaceObject(Vector3 location)
    {
        // original:
        //var obj = Instantiate(objectToPlace, gameObject.transform);
        //obj.transform.position = location;

        var shiftedLocation = location;
        shiftedLocation.z += 6;

        var obj = Instantiate(objectToPlace, location * 1.5f + Camera.main.transform.forward, Quaternion.LookRotation(Camera.main.transform.forward));
        //obj.transform.position = location;

        Quaternion q = obj.transform.rotation;
        q.x = 0;
        q.z = 0;

        obj.transform.rotation = q;

        //Vector3 lookPos = Camera.main.transform.position - obj.transform.position;
        //lookPos.y = 0;
        //obj.transform.rotation = Quaternion.LookRotation(lookPos);

        //float distance = 0.5f;

        //var obj = Instantiate(objectToPlace, Camera.main.transform.position + Camera.main.transform.forward * distance, Camera.main.transform.rotation);
        //obj.transform.position = location;

        //forse mi basta fare l'enable dell'oggetto tipo e posizionarlo nella location del pavimento?
        //objectToPlace.SetActive(true);
        //objectToPlace.transform.position = location;
    }
}
