import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Component;
import java.awt.Graphics;
import java.awt.Panel;
import java.util.Vector;
import javax.swing.JOptionPane;
import javax.swing.JList;
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
	JPanel panel;
	private String[] elements = new String[6];
	JList listLevels;

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
		parking = new Parking(5);
		initialize();
		for (int i = 0; i < 5; i++) {
			elements[i] = "������� " + (i+1);
		}
		listLevels.setSelectedIndex(parking.getCurrentLevel());
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1080, 559);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		panel = new Panel1(parking);
		panel.setBounds(10, 11, 854, 499);
		frame.getContentPane().add(panel);

		JButton btnSetSamolet = new JButton("�������� ������");
		btnSetSamolet.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {
				Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
								if (colorDialog != null) {
									Itechnica samolet = new Samolet(100, 4, 1000, colorDialog);
									int place = parking.putSamolet(samolet);
									panel.repaint();
									JOptionPane.showMessageDialog(null, "���� ����� " + place);
				 				}
			}
		});
		btnSetSamolet.setBounds(939, 293, 115, 23);
		frame.getContentPane().add(btnSetSamolet);

		JButton btnSetfrontovoibombardir= new JButton("�������� ��������������");
		btnSetfrontovoibombardir.addActionListener(new ActionListener(){
			public void actionPerformed(ActionEvent e) {
				Color colorDialog1 = JColorChooser.showDialog(null, "JColorChooser Sample", null);
								if (colorDialog1 != null) {
								       Color colorDialog = JColorChooser.showDialog(null, "JColorChooser Sample", null);
									if (colorDialog != null) {
										Itechnica samolet = new frontovoibombardir(100, 4, 1000, colorDialog1, true, true, colorDialog);
										int place = parking.putSamolet(samolet);
										panel.repaint();
										JOptionPane.showMessageDialog(null, "������ " + place);
									}
			}
			}
		});
		btnSetfrontovoibombardir.setBounds(939, 330, 115, 23);
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
        
		listLevels = new JList(elements);
		listLevels.setBounds(891, 373, 153, 111);
		frame.getContentPane().add(listLevels);
		
		JButton btnLevelDown = new JButton("Down");
		btnLevelDown.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent arg0) {
				parking.levelDown();
				listLevels.setSelectedIndex(parking.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelDown.setBounds(869, 495, 89, 23);
		frame.getContentPane().add(btnLevelDown);
		
		JButton btnLevelUp = new JButton("Up");
		btnLevelUp.addActionListener(new ActionListener() {
		public void actionPerformed(ActionEvent e) {
			parking.levelUp();
				listLevels.setSelectedIndex(parking.getCurrentLevel());
				panel.repaint();
			}
		});
		btnLevelUp.setBounds(973, 495, 89, 23);
		frame.getContentPane().add(btnLevelUp);
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
