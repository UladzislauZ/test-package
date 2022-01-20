using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UladzislauTools
{
    public static class Tools
    {
        public static void MoveXPosition(this Transform t)
        {
            var x = Input.GetAxis("Horizontal");
            t.position += new Vector3(x, 0, 0);
        }
    }
}
