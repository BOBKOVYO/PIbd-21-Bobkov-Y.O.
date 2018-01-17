import java.awt.Graphics;

public interface Itechnica 
{
	    void drawSamolet(Graphics g);
		void moveSamolet(Graphics g);
		void setPosition(int x, int y);
		void loadVzletMass(int count);
        int getVzletMass();
}
