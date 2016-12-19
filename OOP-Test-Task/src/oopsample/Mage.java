package oopsample;

// inheritance from base class
public class Mage extends BaseHero {
    Mage() {}
    Mage(String name) {
        super(name, 10, 75, 0.25f);
        System.out.println("Created: " + this.toString());
    }
}
