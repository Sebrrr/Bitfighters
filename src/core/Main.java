package core;

import java.awt.Dimension;
import javax.swing.JFrame;
import processing.awt.PSurfaceAWT;

public class Main {

	public static void main(String args[]) {
		Canvas drawing = new Canvas();
		
		PSurfaceAWT surf = (PSurfaceAWT) drawing.getSurface();
		PSurfaceAWT.SmoothCanvas canvas = (PSurfaceAWT.SmoothCanvas) surf.getNative();
		JFrame window = (JFrame)canvas.getFrame();

		window.setSize(720, 720);
		window.setMinimumSize(new Dimension(720,720));
		window.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		window.setResizable(true);

		window.setVisible(true);
		
	}

}
