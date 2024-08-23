using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;


public static class RM_CurveEvents
{
    public static event EventHandler<Vector3> OnCurvePointMoved;

    public static void RaiseCurvePointMoved(object sender, Vector3 curvePoint)
    {
        OnCurvePointMoved.Invoke(sender, curvePoint);
    }

}

