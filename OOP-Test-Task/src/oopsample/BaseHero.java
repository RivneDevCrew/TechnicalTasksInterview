package oopsample;

import java.util.Random;

class BaseHero implements Hero {
    String name;
    int damage;
    int health;
    float blockChance;
    
    BaseHero() {}
    BaseHero(String name, int damage, int health, float blockChance)
    {
        this.name = name;
        this.damage = damage;
        this.health = health;
        this.blockChance = blockChance;
    }
    
    @Override
    public int GetHealth() {
        return this.health;
    }
    @Override
    public void SetHealth(int newValue) {
        this.health = newValue;
    }
    
    @Override
    public float GetBlockChance() {
        return this.blockChance;
    }
    
    @Override
    public String GetName() {
        return this.name;
    }
    
    @Override
    public Boolean IsDead() {
        Boolean result = (this.health == 0);
        if(result)
            System.out.println(this.GetName() + " is dead.");
        return result;
    }

    @Override
    public void Attack(Hero victim) {
        if(!victim.IsDead()) {
            System.out.println(this.GetName() + " tries to attack " + victim.GetName());
            if(!victim.Block()) {
                victim.SetHealth(victim.GetHealth() - this.damage);
                System.out.println(victim.GetName() + " was damaged (-" + this.damage + " health)");
                if(victim.GetHealth() < 0)
                    victim.SetHealth(0);
            }
            else
                System.out.println(this.GetName() + " blocked all damage!");
        }
        else {
            victim.SetHealth(0);
            System.out.println(victim.GetName() + " is dead.");
        }
    }

    @Override
    public Boolean Block() {
        Random rand = new Random();
        float chance = rand.nextInt(1) * 0.1f;
        
        return chance > this.blockChance;
    }

    @Override
    public void Heal(int health) {
        this.health += health;
        System.out.println(this.GetName() + " was healed (+" + health + ")");
    }
    
    @Override
    public String toString() {
        return this.name + "\t[Health = " + this.health + " | Damage = " + this.damage + "]";  
    }
}
