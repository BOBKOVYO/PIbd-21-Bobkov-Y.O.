import java.awt.Color;
import java.awt.Graphics;

public class Parking {
	aerodrom<Itechnica> parking;

	int countPlaces = 20;
	int placeWidth = 210;
	int placeHeight = 80;

	public Parking()
	{
		parking = new aerodrom<Itechnica>(countPlaces, null);
	}

	public int putSamolet(Itechnica samolet)
	{
		return parking.plus(parking, samolet);
	}

	public Itechnica getSamolet(int index)
	{
		return parking.minus(parking, index);
	}

	public void draw(Graphics g,int width,int height)
	{
		drawMarking(g);
		for(int i = 0; i < countPlaces; i++)
		{
			Itechnica samolet = parking.getObject(i);
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
