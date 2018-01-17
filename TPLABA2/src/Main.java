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
import javax.swing.JMenu;
import javax.swing.JMenuBar;
import javax.swing.JMenuItem;
import javax.swing.JFrame;
import javax.swing.JPanel;
import javax.swing.JTextField;
import javax.swing.JButton;
import javax.swing.JColorChooser;
import javax.swing.JFileChooser;
import javax.swing.JLabel;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.IOException;
import java.awt.event.ActionEvent;
import javax.swing.JCheckBox;
import java.util.logging.FileHandler;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Main {

	private JFrame frame;
	Parking parking;
	private Frame btnColor;
	private Frame btnSelectdopColor;
	private JTextField numPlace; 
	JPanel panel;
	private String[] elements = new String[6];
	JList listLevels;
	SelectSamolet select;
	private static Logger log;

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
		log = Logger.getLogger(Main.class.getName());
				FileHandler fh = null;
				try {
					fh = new FileHandler("D:\\log.txt");
				} catch (SecurityException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				} catch (IOException e) {
					// TODO Auto-generated catch block
					e.printStackTrace();
				}
				log.addHandler(fh);
		initialize();
		for (int i = 0; i < 5; i++) {
			elements[i] = "������� " + (i+1);
		}
		listLevels.setSelectedIndex(parking.getCurrentLevel());
	}
	public void getSamolet() {
				select = new SelectSamolet(frame);
				if (select.res()) {
					Itechnica samolet = select.getSamolet();
					int place = 0;
							try {
									place = parking.putSamolet(samolet);
									log.log(Level.INFO,"��������� ������� �� ����� " + place);
								} catch (ParkingOverflowException e) {
									// TODO Auto-generated catch block
									e.printStackTrace();
									JOptionPane.showMessageDialog(null, "������ ������������");
								} catch (Exception ex) {
									JOptionPane.showMessageDialog(null, "����� ������");
								}
					panel.repaint();
				System.out.println("���� �����: " + place);
			}
	}
	/**
	 * Initialize the contents of the frame.
	 */
	
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(100, 100, 1080, 580);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);
		
		panel = new Panel1(parking);
		panel.setBounds(10, 11, 854, 499);
		frame.getContentPane().add(panel);
		
		JPanel panelTake = new JPanel();
		panelTake.setBounds(901, 11, 153, 170);
		frame.getContentPane().add(panelTake);
		JButton btnTake = new JButton("�����");
				btnTake.addActionListener(new ActionListener() {
					public void actionPerformed(ActionEvent arg0) {
						
						if(checkPlace(numPlace.getText())) {							
							Itechnica samolet = null;
												try {
													samolet = parking.getSamolet(Integer.parseInt(numPlace.getText()));
													log.log(Level.INFO,"������� ������� � ����� " + numPlace.getText());
												} catch (ParkingIndexOutOfRangeException e) {
													// TODO Auto-generated catch block
													JOptionPane.showMessageDialog(null, "�������� �����");
												} catch (Exception ex) {
													JOptionPane.showMessageDialog(null, "����� ������");
												}
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
		
		JLabel lblNewLabel = new JLabel("�����:");
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
		
		JButton btnGetSamolet = new JButton("��������");
		btnGetSamolet.addActionListener(new ActionListener() {
					@SuppressWarnings("deprecation")
					public void actionPerformed(ActionEvent e) {
						getSamolet();
					}
				});
		        btnGetSamolet.setBounds(927, 300, 96, 23);
				frame.getContentPane().add(btnGetSamolet);
		
	JMenuBar menuBar = new JMenuBar();
			JMenu menu = new JMenu("File");
			frame.setJMenuBar(menuBar);
			menuBar.add(menu);
		JMenuItem menuSave = new JMenuItem("Save");
			menu.add(menuSave);
			JMenuItem menuOpen = new JMenuItem("Open");
			menu.add(menuOpen);
	
			menuSave.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent arg0) {
	
					JFileChooser filesave = new JFileChooser();
	
					if (filesave.showDialog(null, "Save") == JFileChooser.APPROVE_OPTION) {
						try {
							if (parking.save(filesave.getSelectedFile().getPath()))
								if (filesave.getSelectedFile().getPath() != null)
									System.out.println("�������");
							        log.log(Level.INFO,"��������� �������� � ���� " + filesave.getSelectedFile().getName());
						} catch (IOException e) {
							// TODO Auto-generated catch block
							e.printStackTrace();
						}
					}
				}
			});
	
			menuOpen.addActionListener(new ActionListener() {
				public void actionPerformed(ActionEvent arg0) {
					JFileChooser fileopen = new JFileChooser();
					if (fileopen.showDialog(null, "Open") == JFileChooser.APPROVE_OPTION) {
						if (parking.load(fileopen.getSelectedFile().getPath()))
							if (fileopen.getSelectedFile().getPath() != null)
								System.out.println("�������");
								log.log(Level.INFO,"��������� �������� �� ����� " + fileopen.getSelectedFile().getName());
					}
					panel.repaint();
				}			
			});
			JButton btnSort = new JButton("Sort");
			 		btnSort.addActionListener(new ActionListener() {
			 			public void actionPerformed(ActionEvent arg0) {
			 				parking.sort();
			 				panel.repaint();
			 			}
			 		});
			 		btnSort.setBounds(925, 330, 89, 23);
			 		frame.getContentPane().add(btnSort);
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
