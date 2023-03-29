public class BottleOfWater
{
    public string Vendor { get; set; }
    public int Capacity { get; set; }

    bool PickedUp { get; set; }

    public BottleOfWater(string vendor, int capacity, bool pickedUp)
    {
        Vendor = vendor;
        Capacity = capacity;
        PickedUp = pickedUp;
    }

    public void PickUpBottle()
    {
        if (!PickedUp)
        {
            PickedUp = true;
        }
    }

    public void PlaceBottleDown()
    {
        PickedUp = false;
    }

    public void TakeASip(int sizeOfSip)
    {
        if (Capacity > 0)
        {
            if (sizeOfSip <= Capacity)
            {
                Capacity -= sizeOfSip;
                Console.WriteLine("that was nice, your character's thirst has been quenched");
            }
            else
            {
                Capacity = 0;
                Console.WriteLine("not quite there, but still something");
            }
        }
        else
        {
            Console.WriteLine("uh, oh, no more water left!");
        }

    }
}