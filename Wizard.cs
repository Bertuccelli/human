class Wizard:Human {
    public Wizard(
        string name,
        int strength,
        int dexterity
    ): base(name){
        Name = name;
        Strength = strength;
        Intelligence = 25;
        Dexterity = dexterity;
        Health = 50;
    }

    public override int Attack(Human target){
        target.Health -= Intelligence*5;
        return target.Health;
    }

    public int Heal(Human target){
        target.Health += Intelligence * 10;
        return target.Health;
    }

    public int Heal(){
        Health += Intelligence * 10;
        return Health;
    }

}