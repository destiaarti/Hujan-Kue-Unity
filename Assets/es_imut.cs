using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class es_imut : MonoBehaviour
{

    private float slowMoTimeScale;  //slow motion time scale
    private float fastMoTimeScale;  //fast motion time scale
    private float factor = 4f;
    public float timeForChangeSprite;
    private float increasingTime;//factor to increase or decrease the timescale by
    // Use this for initialization
    void Start()
    {
        slowMoTimeScale = Time.timeScale / factor;    //calculate the new timescale
        fastMoTimeScale = Time.timeScale * 1f;
    }

    // Update is called once per frame
    void Update()
    {
        //rotate the cube at a constant rate

    }

    //add slow motion effect
    IEnumerator slowMo()
    {
        if (pindah1.skip >= 1)
        {
            Time.timeScale = slowMoTimeScale;
            //reduce this to the same proportion as timescale to ensure smooth simulation
            yield return new WaitForSeconds(3);
            pindah1.skip -= 1;
            //assign new time scale value
            fastMo();
            yield return null;
        }
      
    

    }
    public void alonwae()
    {
        StartCoroutine(slowMo());
    }
    
    //add fast motion effect
    void fastMo()
    {
        Time.timeScale = fastMoTimeScale;
        Time.fixedDeltaTime = Time.fixedDeltaTime * Time.timeScale;
    }
}

