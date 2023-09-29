namespace TheduelAlbin
{
    internal class Player
    {
        public string Name { get; }


        //sätter health till 100.
        public int Health { get; set; } = 100;



        public Player(string name)
        {

            Name = name;

        }

        public int RollDamage()
        {
            //använder en klass som ska generera ett random nummer och returnerar en random siffra mellan 1 och 50.
            return new Random().Next(1, 51);

        }
    }
}
