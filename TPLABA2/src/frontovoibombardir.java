
import java.awt.Color;
import java.awt.Graphics;

public class frontovoibombardir extends Samolet {

	private boolean raketi;
	private boolean pylimet;

	private Color dopColor;

	public frontovoibombardir(int maxSpeed,int maxCountVzletMass, double weight, Color color, boolean raketi, boolean pylimet,Color dopColor) {
		super(maxSpeed, maxCountVzletMass, weight, color);
		// TODO Auto-generated constructor stub
		this.raketi = raketi;
		this.pylimet = pylimet;
		this.dopColor = dopColor;

	}

	protected void GrajdanSamolet(Graphics g) {
		super.GrajdanSamolet(g);
		g.setColor(dopColor);
		if (raketi) {		
            g.fillRect(startPosX + 40, startPosY + 7, 15, 5);
            g.fillRect(startPosX + 40, startPosY + 37, 15, 5);
            g.fillOval(startPosX + 53, startPosY + 6, 5, 6);
            g.fillOval(startPosX + 53, startPosY + 36, 5, 6);
		}
		if (pylimet) {
			Color color = new Color(0,0,0);
			g.setColor(color);
			g.drawLine(startPosX + 75, startPosY + 30, startPosX + 75, startPosY + 35);
            g.drawLine(startPosX + 65, startPosY + 35, startPosX + 85, startPosY + 35);
		}
	}
}
