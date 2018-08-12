package core;

import java.awt.*;

public class Weapon extends Block {

    public static final float attackRange = 100;
    private int direction;
    private int charge = 0;

    public Weapon(float x, float y, int direction) {
        super(x, y, 10, 10);
        setFill(new Color(155, 155, 0));
        this.direction = direction;
    }

    public void charge() {
        if (charge <= 99) {
            setFill(new Color(155 + charge, 155 + charge, 0));
            charge++;
        }
    }

    public void release() {
        charge = 0;
        setFill(Color.BLACK);
    }

    public int getCharge() {
        return charge;
    }

    public int getDirection() {
        return direction;
    }

    public void setDirection(int direction){
        if(charge == 100){
            release();
            this.direction = direction;
        }
    }
}
