package oopsample;

import java.util.ArrayList;
import java.util.List;
import java.util.Random;

public class OOPSample {
    public static void main(String[] args) {
        Random rand = new Random();
        
        // usage of polymorphism - creating instances of heroes based on common interface
        List<Hero> heroes = new ArrayList<>();
        for(int i = 1; i <= 3; ++i) {
            Hero archer = new Archer("Archer #" + i);
            Hero mage = new Mage("Mage #" + i);
            Hero warrior = new Warrior("Warrior #" + i);
            heroes.add(archer);
            heroes.add(mage);
            heroes.add(warrior);
        }
        
        // a few suicides are coming...
        for(Hero hero : heroes) {
            hero.Attack(hero);
            if(!hero.IsDead())
                hero.Heal(rand.nextInt(20));
        }
    }
}
