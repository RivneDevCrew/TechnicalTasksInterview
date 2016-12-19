package oopsample;

// inheritance from base class
public class Archer extends BaseHero {
    Archer() {}
    Archer(String name) {
        super(name, 15, 50, 0.1f);
        System.out.println("Created: " + this.toString());
    }
    
    @Override
    public String toString() {
        return this.name + " [Health = " + this.health + " | Damage = " + this.damage + "]";  
    }
}
