package core;


import demo.PlayerOne;
import demo.PlayerTwo;
import processing.core.PApplet;

import java.awt.*;
import java.awt.event.KeyEvent;
import java.awt.geom.Point2D;
import java.util.ArrayList;


public class Canvas extends PApplet {

    public static final int FPS = 60;
    public static final long RoundLength = 60;

    public double timeElapsed = 0;

    public ArrayList<Block> blocks = new ArrayList<>();

    Player one, two;

    public Canvas() {
        runSketch();
    }

    public void setup(){
        blocks.add(new Block(0, 600, 720, 20));
        blocks.add(new Block(200, 100, 320, 20));
        blocks.add(new Block(125, 300, 470, 20));
        blocks.add(new Block(200, 500, 320, 20));
        blocks.add(new Block(0, 400, 75, 20));
        blocks.add(new Block(645, 400, 75, 20));
        blocks.add(new Block(0,0,720, 30));

        one = new Player(200, 100, Color.RED);
        two = new Player( 420, 100, Color.BLUE);
        one.setOpponent(two);
        two.setOpponent(one);
      }

    public void draw(){
        timeElapsed += 1.0f/FPS;

        if(timeElapsed >= RoundLength){
            exit();
            System.out.println("DRAW");
        }

        clear();
        
        drawBackground();

        PlayerOne.act(one);
        PlayerTwo.act(two);

        one.draw(this);
        two.draw(this);

        for (Block block:
             blocks) {
            block.draw(this);
        }

        fill(Color.RED.getRGB());
        rect(0,0, 20*(one.health), 20);
        fill(Color.BLUE.getRGB());
        rect(720 - 20*(two.health),0, 20*(two.health), 20);

        if(one.health == 0){
            System.out.println("two wins");
            this.exit();
        } else if(two.health == 0){
            System.out.println("one wins");
            this.exit();
        }
    }

    private void drawBackground() {
        fill(Color.WHITE.getRGB());
        rect(0, 0, 720, 720);
    }

    public void keyPressed(){
        if(keyCode == 32){
            one.jump();
        }
        if(keyCode == 39){
            one.moveRight();
        }
        if(keyCode == 37){
            one.moveLeft();
        }
    }
}










