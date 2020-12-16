namespace lớp_Animal_và_interface_Edible
{
    public  class Chicken : Animal, Edible
    {
        public override string MakeSound()
        {
            return "chicken: chuck chuck";
        }
        public string Howtoeat(){
            return "could be fried";
        }
    }
}