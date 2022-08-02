class Ninja:Human {
    public Ninja(
        string name,
        int strength,
        int intelligence,
        int health
    ): base(name){
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = 175;
        Health = health;
    }

    public override int Attack(Human target) {
        int damage = 5* Dexterity;
        Random rand = new Random();
        int chance = rand.Next(1,6);

        if(chance ==3) {
            damage += 10;
        }
        target.Health -= damage;
        return target.Health;
    }

    public int Steal(Human target){
        target.Health -= 5;
        return target.Health;
    }

    public int Steal(){
        Health += 5;
        return Health;
    }

}