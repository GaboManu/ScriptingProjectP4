using UnityEngine;

public class Interpolation : MonoBehaviour
{ /*
     In this case, result = 4
    float result = Mathf.Lerp(3f, 5f, 0.5f);
     this script works by taking float parameters: one representing the value to interpolate from; another representing the value to interpolate to and a final float representing how far to interpolate
}

 void Update ()
 {
 Light.intensity = Mathf.Lerp(Light.intensity, 8f, 0.5f);
 }
 This script uses the same principles as mathf.Lerp If the intensity of the light starts off at 0 then after the first update it will be set to 4. The next frame it will be set to 6, then to 7, then to 7.5 and so on. Thus over several frames, the lights intensity will tend towards 8 but the rate of its change will slow as it approaches its target.

 To make this scrript not frame dependant use the following script

  void Update ()
  {
  Light.intensity = Mathf.Lerp(Light.intensity, 8f, 0.5f * Time.deltaTime);
  }
 */
}