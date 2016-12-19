package oopsample;

// inheritance from base class
public class Warrior extends BaseHero {
    Warrior() {}
    Warrior(String name) {
        super(name, 5, 100, 0.4f);
        System.out.println("Created: " + this.toString());
    }
}
