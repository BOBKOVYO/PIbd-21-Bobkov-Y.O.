import java.awt.Color;
import java.awt.Graphics;
import java.util.ArrayList;

public class Parking {
	ArrayList<aerodrom<Itechnica>> parkingStages;
	
	int countPlaces = 20;
	int placeWidth = 210;
	int placeHeight = 80;
	int currentLevel;

	public Parking(int countStages)
	{
		parkingStages = new ArrayList<aerodrom<Itechnica>>(countStages);
		for (int i = 0; i < countStages; i++)
		{
			parkingStages.add(new aerodrom<Itechnica>(countPlaces, null));
		}
	}
	public int getCurrentLevel(){
		return currentLevel;	
	}
				
	public void levelUp()
	{
		if (currentLevel + 1 < parkingStages.size()) currentLevel++;
	}
		
	public void levelDown()
	{
		if (currentLevel > 0) currentLevel--;
	}
	public int putSamolet(Itechnica samolet)
	{
		return parkingStages.get(currentLevel).plus(parkingStages.get(currentLevel), samolet);
	}

	public Itechnica getSamolet(int index)
	{
		return parkingStages.get(currentLevel).minus(parkingStages.get(currentLevel), index);
	}

	public void draw(Graphics g,int width,int height)
	{
		drawMarking(g);
		for(int i = 0; i < countPlaces; i++)
		{
			Itechnica samolet = parkingStages.get(currentLevel).getSamolet(i);
			if (samolet != null)
			{
				samolet.setPosition(5 + i / 5 * placeWidth , i % 5 * placeHeight + 15);
				samolet.drawSamolet(g);
			}
		}
		
	}

	public void drawMarking(Graphics g)
	{
		g.setColor(Color.BLACK);
		g.drawRect( 0, 0, (countPlaces / 5) * placeWidth, 480);
		for(int i = 0; i < countPlaces / 5; i++)
		{
			for(int j = 0; j < 6; j++)
			{
				g.drawLine( i * placeWidth,j* placeHeight,i*placeWidth+140,j*placeHeight);
			}
			g.drawLine( i * placeWidth, 0, i * placeWidth,400);
		}
		
	}


}
