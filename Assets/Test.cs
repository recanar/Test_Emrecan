using System.Collections;
using System.Collections.Generic;
using Dreamteck.Splines;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject splin;
    private Spline spline;

    private SplineComputer splineScript;
    // Start is called before the first frame update
    void Start()
    {
        splineScript = splin.GetComponent<SplineComputer>();

        spline = new Spline(Spline.Type.BSpline,1);

        spline.points = new SplinePoint[4];
        spline.points[0] = new SplinePoint(Vector3.zero);
        spline.points[1] = new SplinePoint(Vector3.forward*10);
        spline.points[2] = new SplinePoint(Vector3.forward*20);
        spline.points[3] = new SplinePoint(Vector3.forward*30);
        spline.points[3] = new SplinePoint(Vector3.forward*40);
        spline.points[3] = new SplinePoint(Vector3.forward*50);
        spline.points[3] = new SplinePoint(Vector3.forward*60);

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            splineScript.SetPoint(i,spline.points[i],SplineComputer.Space.Local);
        }
        
    }
}
