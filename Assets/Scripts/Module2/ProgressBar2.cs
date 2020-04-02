using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar2 : MonoBehaviour
{
    private Slider slider;
    public float FillSpeed = 0.5f;
    private float targetProgress = 1;
    // Start is called before the first frame update
    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }
    void Start()
    {
        IncrementProgress(1.0f);
    }

    // Update is called once per frame
    void Update()
    {

        // Emeka placed this code
        float slidervalue = slider.value;
        float timedelta = Time.deltaTime;


        new ProgressTestBarTwo().checkUpdateLogic(slidervalue, targetProgress, FillSpeed, timedelta);

        /*if (slider.value > targetProgress)
        {
            slider.value -= FillSpeed * Time.deltaTime;
        }*/
    }
    public void IncrementProgress(float newProgress)
    {
        float slidevalue = slider.value;

        new ProgressTestBarTwo().checkIncrementLogic(targetProgress, slidevalue, newProgress);
        /*targetProgress = slider.value - newProgress;*/
    }
}
public class ProgressTestBarTwo
{
    public float testSlidevalue;
    public float testTargetProgress;
    public void checkUpdateLogic(float slidervalue, float targetProgress, float FillSpeed, float timedelta)
    {
        if (slidervalue > targetProgress)
        {
            slidervalue -= FillSpeed * timedelta;
            testSlidevalue = slidervalue;
        }
    }

    public void checkIncrementLogic(float targetProgress, float slidevalue, float newProgress)
    {
        targetProgress = slidevalue - newProgress;
        testTargetProgress = targetProgress;
    }
}