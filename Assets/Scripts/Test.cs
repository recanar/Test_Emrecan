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

        spline.points = new SplinePoint[8];
        spline.points[0] = new SplinePoint(Vector3.zero);
        spline.points[1] = new SplinePoint(Vector3.forward*10);
        spline.points[2] = new SplinePoint(Vector3.forward*20+Vector3.right*5);
        spline.points[3] = new SplinePoint(Vector3.forward*30);
        spline.points[4] = new SplinePoint(Vector3.forward*40+Vector3.left*5);
        spline.points[5] = new SplinePoint(Vector3.forward*50);
        spline.points[6] = new SplinePoint(Vector3.forward*60+Vector3.right*5);
        spline.points[7] = new SplinePoint(Vector3.forward*70);
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
