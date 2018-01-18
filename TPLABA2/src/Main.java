import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Component;
import java.awt.Graphics;
import java.awt.Panel;

import javax.swing.JOptionPane;

import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JLabel;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;

public class Main {

	private JFrame frame;
	Parking parking;
	private Frame btnColor;
	private Frame btnSelectdopColor;
	private JTextField numPlace; 

	/**
	 * Launch the application.
	 */
	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					Main window = new Main();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public Main() {
		parking = new Parking();
		initialize();

	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1190, 559);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		JPanel panel = new Panel1(parking);
        panel.setBounds(10, 11, 854, 499);
		frame.getContentPane().add(panel);

	
		JButton btnSetSamolet = new JButton("Посадить самолёт");
		btnSetSamolet.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {

				Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
								if (colorDialog != null) {
									Itechnica samolet = new Samolet(100, 4, 1000, colorDialog);
									int place = parking.putSamolet(samolet);
									panel.repaint();
									JOptionPane.showMessageDialog(null, "Ваше место " + place);
				 				}
			}
		});
		btnSetSamolet.setBounds(910, 293, 190, 23);
		frame.getContentPane().add(btnSetSamolet);

		JButton btnSetfrontovoibombardir= new JButton("Посадить бомбардировщик");
		btnSetfrontovoibombardir.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null, "JColorChooser Sample", null);
								if (colorDialog1 != null) {
								       Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
									if (colorDialog != null) {
										Itechnica samolet = new frontovoibombardir(100, 4, 1000, colorDialog1, true, true, colorDialog);
										int place = parking.putSamolet(samolet);
										panel.repaint();
										JOptionPane.showMessageDialog(null, "Самолёт " + place);
									}
			}
			}
		});
		btnSetfrontovoibombardir.setBounds(880, 330, 250, 23);
		frame.getContentPane().add(btnSetfrontovoibombardir);
		JPanel panelTake = new JPanel();
		panelTake.setBounds(901, 11, 153, 170);
		frame.getContentPane().add(panelTake);
		JButton btnTake = new JButton("Take");
				btnTake.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent arg0) {
						
						if(checkPlace(numPlace.getText())) {
							Itechnica samolet = parking.getSamolet(Integer.parseInt(numPlace.getText()));
							Graphics gr = panelTake.getGraphics();
							gr.clearRect(0, 0, panelTake.getWidth(), panelTake.getHeight());
							samolet.setPosition(5, 5);
							samolet.drawSamolet(gr);
							panel.repaint();
		 				}
		}
		});
        
		btnTake.setBounds(973, 233, 81, 23);
		frame.getContentPane().add(btnTake);
		
		JLabel lblNewLabel = new JLabel("Place");
		lblNewLabel.setBounds(912, 205, 46, 14);
		frame.getContentPane().add(lblNewLabel);
		
		numPlace = new JTextField();
		numPlace.setBounds(968, 202, 86, 20);
		frame.getContentPane().add(numPlace);
		numPlace.setColumns(10);

	}

	private boolean checkPlace(String str){
		try {
	        Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
	}
		if(Integer.parseInt(str)>20) return false;
		return true;
	}
}
