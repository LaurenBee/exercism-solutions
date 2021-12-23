class BirdCount
{
    private readonly int[] _birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        _birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new []{0,2,5,3,7,8,4};
    }

    public int Today()
    {
        return _birdsPerDay[6];
    }

    public void IncrementTodaysCount()
    {
        //var number = 1;
        //number++;
        _birdsPerDay[6] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (var dayCount in _birdsPerDay)
        {
            if (dayCount == 0)
            {
                return true;
            }
        }

        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var sum = 0;

        for (var i = 0; i < numberOfDays; i++)
        {
            sum += _birdsPerDay[i];
        }

        return sum;
    }

    public int BusyDays()
    { 
        var sum = 0;

        foreach (var dayCount in _birdsPerDay)
        {
            if (dayCount >= 5)
            {
                sum++;
            }
        }

        //return birdsPerDay.Count(dayCount => dayCount >= 5);

        return sum; 
    }
}
