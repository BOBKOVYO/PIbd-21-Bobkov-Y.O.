import java.awt.Color;
import java.awt.Graphics;
import java.util.Random;

public class Samolet extends letniitransport {

	public Samolet(int maxSpeed, int maxCountVzletMass, double weight, Color color) {
		this.maxSpeed = maxSpeed;
		this.maxcountVzletMass = maxCountVzletMass;
		this.weight = weight;
		this.colorBody= color;
		this.countVzletMass = 0;
        
		startPosX = 10;
		startPosY = 100;

	}

	@Override
	protected void setmaxSpeed(int s) {
		// TODO Auto-generated method stub
		if (s > 0 && s < 1500)
			super.maxSpeed = s;
		else
			super.maxSpeed = 750;
	}

	@Override
	public int getmaxSpeed() {
		// TODO Auto-generated method stub
		return super.maxSpeed;
	}

	@Override
	protected void setweight(double w) {
		// TODO Auto-generated method stub
		if (w > 60000 && w < 120000)
			super.weight = w;
		else
			super.weight = 90000;
	}

	@Override
	public double getweight() {
		// TODO Auto-generated method stub
		return super.weight;
	}

	@Override
	protected void setmaxcountVzletMass(int c) {
		// TODO Auto-generated method stub
		if (c > 0 && c < 150000)
			super.maxcountVzletMass = c;
		else
			super.maxcountVzletMass = 100000;
	}

	@Override
	public int getmaxcountVzletMass() {
		// TODO Auto-generated method stub
		return super.maxcountVzletMass;
	}

	@Override
	public void moveSamolet(Graphics g) {
		// TODO Auto-generated method stub
		startPosX +=(maxSpeed * 500 / (float)weight) / (countVzletMass == 0 ? 1 : countVzletMass);
		drawSamolet(g);
	}

	@Override
	public void drawSamolet(Graphics g) {
		// TODO Auto-generated method stub
		GrajdanSamolet(g);
	}

	protected void GrajdanSamolet(Graphics g) {
		//хвост
		Color newColor = new Color(0, 0, 0);
		g.setColor(newColor);
        g.drawLine(startPosX, startPosY, startPosX + 10, startPosY + 15);
        g.drawLine(startPosX, startPosY, startPosX, startPosY + 15);
        //тело 
        g.setColor(colorBody);
        g.fillRect(startPosX, startPosY + 15, 85, 15);        
        //передняя часть
        g.setColor(newColor);
        g.drawLine(startPosX + 85, startPosY + 15, startPosX + 95, startPosY + 30);
        g.drawLine(startPosX + 80, startPosY + 30, startPosX + 95, startPosY + 30);
        //крылья 
        g.drawLine(startPosX + 45, startPosY - 10, startPosX + 55, startPosY + 15);
        g.drawLine(startPosX + 45, startPosY - 10, startPosX + 45, startPosY + 15);
        g.drawLine(startPosX + 45, startPosY + 55, startPosX + 55, startPosY + 30);
        g.drawLine(startPosX + 45, startPosY + 30, startPosX + 45, startPosY + 55);
	}

	@Override
	public void setPosition(int x, int y) {
		startPosX = x;
        startPosY = y;		
	}
}

