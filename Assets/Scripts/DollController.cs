using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollController : MonoBehaviour
{
    public float minTimer, maxTimer;

    public bool isGreenLight = true;

    public Animator animator;

    public readonly string greenLightAnim = "GreenLight";
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ChangeLightCoroutine());
    }

    IEnumerator ChangeLightCoroutine()
    {
        yield return new WaitForSeconds(Random.Range(minTimer, maxTimer));

        if (isGreenLight)
        {
            isGreenLight = false;
            animator.SetBool(greenLightAnim,false);
            print("Lampu Merah, Player ga boleh jalan!");
        }
        else
        {
            isGreenLight = true;
            animator.SetBool(greenLightAnim,true);
            print("Lampu Hijau, Player silahkan jalan");
        }

        StartCoroutine(ChangeLightCoroutine());
    }
}
