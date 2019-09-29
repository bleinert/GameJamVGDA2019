using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelBar : MonoBehaviour
{
    public Slider fuelbarslider;
    public Text TxtFuel;
    public int Min;
    public int Max;
    private float mCurrentValue;
    private float mCurrentPercent;
    public PlayerStatsSO playerstats;

    public void SetFuel(float fuel)
    {
        if (fuel != mCurrentValue) {
            if (Max - Min == 0) {
                mCurrentValue = 0;
                mCurrentPercent = 0;
            }
            else
            {
                mCurrentValue = fuel;
                mCurrentPercent = mCurrentValue / (float)(Max - Min);
            }
            TxtFuel.text = string.Format("{0} %", Mathf.RoundToInt(mCurrentPercent * 100));
            fuelbarslider.value = mCurrentPercent;
        }
    }

    private void Update()
    {
        SetFuel(playerstats.playerFuel);

    }

}
