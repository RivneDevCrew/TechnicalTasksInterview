package oopsample;

public interface Hero {
    void Attack(Hero victim);
    Boolean Block();
    void Heal(int health);
    Boolean IsDead();
    
    int GetHealth();
    void SetHealth(int newValue);
    float GetBlockChance();
    String GetName();
}
