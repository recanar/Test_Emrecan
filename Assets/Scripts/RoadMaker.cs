using System.Collections;
using System.Collections.Generic;
using Dreamteck.Splines;
using UnityEngine;

public class RoadMaker : MonoBehaviour
{
    public GameObject splin;
    private Spline spline;
    private SplineComputer splineScript;
    private int roadLength=100;
    // Start is called before the first frame update
    void Start()
    {
        splineScript = splin.GetComponent<SplineComputer>();

        spline = new Spline(Spline.Type.BSpline,1);

        spline.points = new SplinePoint[roadLength];
        spline.points[0] = new SplinePoint(Vector3.zero);
        spline.points[1] = new SplinePoint(Vector3.forward*10);
        spline.points[2] = new SplinePoint(Vector3.forward * 20);
        for (int i = 3; i < roadLength; i++)
        {
            spline.points[i] = new SplinePoint(Vector3.forward*i*10f+Vector3.right*5*Random.Range(-1f,1f));
            print(spline.points[i].position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <8 ; i++)
        {
            splineScript.SetPoint(i,spline.points[i],SplineComputer.Space.Local);
        }
    }
}
