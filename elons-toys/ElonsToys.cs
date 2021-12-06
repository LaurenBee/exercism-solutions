using System;

class RemoteControlCar
{
    private int _metresDriven;
    private int _batteryPercent = 100;

    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_metresDriven} meters";
    }

    public string BatteryDisplay()
    {
        return _batteryPercent != 0 ? $"Battery at {_batteryPercent}%" : "Battery empty";
    }

    public void Drive()
    {
        if (_batteryPercent == 0) return;
        _metresDriven += 20;
        _batteryPercent--;
    }
}
