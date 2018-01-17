import java.awt.BorderLayout;
import java.awt.Color;
import java.awt.EventQueue;
import java.awt.Frame;
import java.awt.Graphics;

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
	private JTextField textMaxSpeed;
	private JTextField textMaxcountVzletMass;
	private JTextField textWeight;

	Color colorBody;
	Color dopColor;
	int maxSpeed;
	double weight;
	int maxcountVzletMass;
	boolean raketi;
	boolean pylimet;

	private Itechnica inter;
	private Frame btnColor;
	private Frame btnSelectFigtherColor;

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
		colorBody = Color.WHITE;
		dopColor = Color.YELLOW;
		maxSpeed = 1000;
		maxcountVzletMass = 4000;
		weight = 30000;
		initialize();

	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 526, 398);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		textMaxSpeed = new JTextField();
		textMaxSpeed.setBounds(81, 227, 86, 20);
		frame.getContentPane().add(textMaxSpeed);
		textMaxSpeed.setColumns(10);

		textMaxcountVzletMass = new JTextField();
		textMaxcountVzletMass.setBounds(130, 261, 86, 20);
		frame.getContentPane().add(textMaxcountVzletMass);
		textMaxcountVzletMass.setColumns(10);

		textWeight = new JTextField();
		textWeight.setBounds(253, 227, 86, 20);
		frame.getContentPane().add(textWeight);
		textWeight.setColumns(10);


		JPanel panel = new JPanel();
		panel.setBounds(10, 11, 357, 195);
		frame.getContentPane().add(panel);

		JCheckBox checkRaketi = new JCheckBox("Check Raketi");
		checkRaketi.setBounds(330, 288, 130, 23);
		frame.getContentPane().add(checkRaketi);

		JCheckBox checkPylimet = new JCheckBox("Check Pylimet");
		checkPylimet.setBounds(330, 314, 130, 23);
		frame.getContentPane().add(checkPylimet);

		JButton btnDrawSamolet = new JButton("Draw Samolet");
		btnDrawSamolet.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (checkFields()) {
					inter = new Samolet(maxSpeed, maxcountVzletMass, weight, colorBody);
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawSamolet(gr);

				}

			}
		});
		btnDrawSamolet.setBounds(29, 292, 115, 23);
		frame.getContentPane().add(btnDrawSamolet);

		JButton btnDrawfrontovoibombardir = new JButton("Draw frontovoibombardir");
		btnDrawfrontovoibombardir.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {
				if (checkFields()) {
					raketi = checkRaketi.isSelected();
					pylimet = checkPylimet.isSelected();
					inter = new frontovoibombardir(maxSpeed, maxcountVzletMass, weight,colorBody, raketi, pylimet, dopColor);
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.drawSamolet(gr);
				}

			}
		});
		btnDrawfrontovoibombardir.setBounds(172, 292, 151, 23);		
		frame.getContentPane().add(btnDrawfrontovoibombardir);

		JButton btnColor = new JButton("Select Color");
		btnColor.setForeground(colorBody);
		btnColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent arg0) {

				Color initialBackground = btnColor.getForeground();
				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnColor.setForeground(foreground);
				}
				colorBody = foreground;
			}
		});
		btnColor.setBounds(29, 326, 115, 23);
		frame.getContentPane().add(btnColor);

		JButton btnMove = new JButton("Движение");
		btnMove.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				if (inter != null) {
					Graphics gr = panel.getGraphics();
					gr.clearRect(0, 0, panel.getWidth(), panel.getHeight());
					inter.moveSamolet(gr);
				}
			}
		});
		btnMove.setBounds(390, 225, 110, 23);
		frame.getContentPane().add(btnMove);

		JButton btnSelectdopColor = new JButton("Select dopColor");
		btnSelectdopColor.setForeground(dopColor);
		btnSelectdopColor.addActionListener(new ActionListener() {
			public void actionPerformed(ActionEvent e) {

				Color initialBackground = btnSelectdopColor.getForeground();
				Color foreground = JColorChooser.showDialog(null, "JColorChooser Sample", initialBackground);
				if (foreground != null) {
					btnSelectdopColor.setForeground(foreground);
				}
				dopColor = foreground;
			}
		});
		btnSelectdopColor.setBounds(172, 326, 151, 23);
		frame.getContentPane().add(btnSelectdopColor);

		JLabel textmaxspeed = new JLabel("Maxspeed");
		textmaxspeed.setBounds(6, 230, 69, 14);
		frame.getContentPane().add(textmaxspeed);

		JLabel textmaxcountvzletmass = new JLabel("MaxcountVzletMass");
		textmaxcountvzletmass.setBounds(6, 264, 120, 14);
		frame.getContentPane().add(textmaxcountvzletmass);

		JLabel textweight = new JLabel("Weight");
		textweight.setBounds(208, 230, 46, 14);
		frame.getContentPane().add(textweight);

	}

	private boolean checkParse(String str) {
		try {
	        Integer.parseInt(str);
		} catch (NumberFormatException e) {
			return false;
	}

		return true;
	}

	private boolean checkFields() {
		if (checkParse(textMaxSpeed.getText()))
			maxSpeed = Integer.parseInt(textMaxSpeed.getText());
      	if (checkParse(textMaxcountVzletMass.getText()))
			maxcountVzletMass = Integer.parseInt(textMaxcountVzletMass.getText());
		if (checkParse(textWeight.getText()))
			weight = Integer.parseInt(textWeight.getText());

		System.out.println(maxSpeed + " "  + weight + " " + maxcountVzletMass);

		return true;
	}
}
