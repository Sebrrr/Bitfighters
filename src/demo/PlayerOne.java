package demo;

import core.Player;

import java.awt.*;

public class PlayerOne {
    public static void act(Player player){
        if (player.distanceToOpponent() > 90) {
            if (player.directionToOpponent() < 90 || player.directionToOpponent() > 270) {
                player.moveRight();
            } else {
                player.moveLeft();
            }
        } else {
            if (player.directionToOpponent() < 90 && player.getFill().equals(Color.BLUE)) {
                if(player.getWeapon().getDirection() == 1){
                    player.attack();
                } else {
                    player.getWeapon().setDirection(1);
                }
            } else {
                if(player.getWeapon().getDirection() == -1){
                    player.attack();
                } else {
                    player.getWeapon().setDirection(-1);
                }
            }
            player.jump();
        }
    }
}
