using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPathMovementrScript : MonoBehaviour
{
    private List<Transform> _waypoints = new List<Transform>();
    private int _currentwaypoint = 0;
    public float speed = 5f;
    public float minDistance = 0.2f;
    public string pathName = "Path";
    // Start is called before the first frame update
    void Start()
    {
        var waypointParent = GameObject.Find("Path");
        for (int i = 0; i < waypointParent.transform.childCount; i++)
        {
            _waypoints.Add(item: waypointParent.transform.GetChild(i));
        }

        StartCoroutine(MoveToNextwaypoint());
    }



    private IEnumerator MoveToNextwaypoint()
    {
        var distance = Vector3.Distance(a: transform.position,
            b: _waypoints[_currentwaypoint].position);
        while (Mathf.Abs(distance) > 0.2f)
        {
            transform.position = Vector3.MoveTowards(current: transform.position,
                _waypoints[_currentwaypoint].position, Time.deltaTime * speed);

            yield return null;
        }


        if (_currentwaypoint < _waypoints.Count - 1)
        {
            _currentwaypoint++;
            StartCoroutine(MoveToNextwaypoint());
        }

    }
}
