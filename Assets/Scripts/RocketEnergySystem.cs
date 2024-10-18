using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RocketEnergySystem : Rocket
{
    [SerializeField] private TextMeshProUGUI FuelTxt;
    [SerializeField] private Image fuelBar;
    [SerializeField] private Button ShootButton;

    private float currentFuel = 100f;
    private float maxFuel = 100f;
    private readonly float FUELPERSHOOT = 10f;
    private readonly float SPEED = 5f;

    private void Update()
    {
        currentFuel += 0.01f;
        currentFuel = Mathf.Min(currentFuel, maxFuel);
        currentFuel = Mathf.Round(currentFuel * 100) / 100;
        fuelBar.fillAmount = currentFuel / maxFuel;
        FuelTxt.text = $"Fuel : {currentFuel}";
    }

    public void Shoot()
    {
        if (currentFuel >= 10)
        {
            currentFuel -= FUELPERSHOOT;
            //fuelBar.fillAmount = currentFuel / maxFuel;
            _rb2d.gravityScale = -SPEED;
        }
        //FuelTxt.text = $"Fuel : {currentFuel}";
    }

    //public void Speed()
    //{
    //    time += Time.deltaTime;
    //    while (time <= 5)
    //    {
    //        float Speed = SPEED;
    //        time = 0f;
    //    }
    //    // 버튼을 누르지 않아도 5초마다 로켓이 움직일 수 있음(수정 필요)
    //}
}