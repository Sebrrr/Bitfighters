package core;

import java.awt.*;

public class Block {
    protected float x;
    protected float y;
    private float width;
    private float height;
    private Color fill = Color.BLACK;

    public Block(float x, float y, float width, float height) {

        this.x = x;
        this.y = y;
        this.width = width;
        this.height = height;
    }

    public float getHeight() {
        return height;
    }

    public float getWidth() {
        return width;
    }

    public float getY() {
        return y;
    }

    public float getX() {
        return x;
    }

    public boolean isTouching(Block other) {
        return x < other.getX() + other.getWidth() && x + width > other.getX() && y < other.getY() + other.getHeight() && y + height > other.getY();
    }

    public boolean[] whereTouching(Block other) {
        boolean[] output = new boolean[5];

        /*
         *  _____2_____
         * |           |
         * 3           1   0
         * |_____4_____|
         */


        if (!isTouching(other)) {
            output[0] = true;
        }

        float pL = x, pR = pL + width, pT = y, pB = pT + height;

        float tL = other.getX(), tR = tL + other.getWidth(), tT = other.getY(), tB = tT + other.getHeight();

        if (pR > tL && pL < tL)             // Player on left
            output[3] = true;
        if (pL < tR && pR > tR)             // Player on Right
            output[1] = true;
        if (pT < tB && pB > tB)             // Player on Bottom
            output[4] = true;
        if (pB > tT && pT < tT)             // Player on Top
            output[2] = true;

        // return the closest intersection
        return output;
    }

    public void draw(Canvas canvas) {
        canvas.noStroke();
        canvas.fill(fill.getRGB());
        canvas.rect(x, y, width, height);
    }

    public Color getFill() {
        return fill;
    }

    public void setFill(Color fill) {
        this.fill = fill;
    }
}
