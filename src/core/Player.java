package core;

import java.awt.*;
import java.util.ArrayList;

public class Player extends Block {
    private float vx = 0, vy = 0;
    static final float gravity = 9.81f / Canvas.FPS;
    static final float jumpVelocity = 8;
    static final float sideVelocity = 1;
    static final float terminalSideVelocity = 5;
    static final float friction = 0.9f;

    private Weapon weapon;
    private Player opponent;
    private boolean jump = false;
    public int health = 10;

    public Player(float x, float y, Color color) {
        super(x, y, 50, 50);
        super.setFill(color);
        weapon = new Weapon(x, y, 0);
    }

    private void cleanup(ArrayList<Block> blocks){
        while(x < 0){
            x++;
        }

        while(x + getWidth() > 720){
            x--;
        }

        while(y < 0){
            y++;
        }

        while(y + getHeight() > 720){
            y--;
        }
    }

    protected void setOpponent(Player opponent) {
        this.opponent = opponent;
    }

    public void setWeapon(Weapon weapon) {
        this.weapon = weapon;
    }

    public boolean nearEdge() {
        return x <= 10 || y <= 10 || x + getWidth() >= 710 || y + getHeight() >= 710;
    }

    public void draw(Canvas canvas) {
        weapon.charge();

        if (nearEdge()) {
            vx = -(Math.copySign(1, (x - 360)) * terminalSideVelocity);
        }
        boolean gravityEnabled = true;

        for (Block other :
                canvas.blocks) {
            boolean[] touches = whereTouching(other);

            if (!touches[0]) {

                if (touches[2]) {
                    //On top of block
                    gravityEnabled = false;
                    vx = vx * friction;
                } else if (touches[4]) {
                    if (vy < 0) {
                        vy = 0;
                    }
                } else if (touches[1]) {
                    vy = vy * friction;
                    if (vx > 0)
                        vx = 0;
                } else if (touches[3]) {
                    vy = vy * friction;
                    if (vx < 0)
                        vx = 0;
                }
            }


        }


        if (gravityEnabled)
            vy += gravity;
        else {
            vy = 0;
            if (jump) {
                vy = vy - jumpVelocity;
                jump = false;
            }
        }


        x += vx;
        y += vy;


        cleanup(canvas.blocks);

        weapon.x = this.x + getWidth()/2 - weapon.getWidth()/2 + weapon.getDirection() * 10;
        weapon.y = this.y + getWidth()/2 - weapon.getHeight()/2;

        super.draw(canvas);

        weapon.draw(canvas);
    }

    /*
    * Player methods
    */

    public void jump() {
        jump = true;
    }

    public void moveLeft() {
        if (Math.abs(vx) < terminalSideVelocity) {
            vx -= sideVelocity;
        }
    }

    public void moveRight() {
        if (Math.abs(vx) < terminalSideVelocity) {
            vx += sideVelocity;
        }
    }

    public float distanceToOpponent() {
        return (float) Math.sqrt(Math.pow(opponent.getX() + opponent.getWidth() / 2 - getX() - getWidth() / 2, 2) + Math.pow(opponent.getY() + opponent.getHeight() / 2 - getY() - getHeight() / 2, 2));
    }

    public float directionToOpponent() {
        return ((float) (Math.toDegrees(Math.atan2((getY() - opponent.getY()), (getX() - opponent.getX()))) + 540)%360);
    }

    public void attack(){
        if(weapon.getCharge() >= weapon.attackRange && (opponent.getX() - x)*weapon.getDirection() <= weapon.attackRange && (opponent.getX() - x)*weapon.getDirection() >= 0){
            opponent.health--;
            weapon.release();
        }
    }

    public Weapon getWeapon() {
        return weapon;
    }

    public Player getOpponent(){
        return opponent;
    }

    /*
     *  _____2_____
     * |           |
     * 3           1   0
     * |_____4_____|
     *
     *
     * <- X ->
     * -1 0 1
     */

}
