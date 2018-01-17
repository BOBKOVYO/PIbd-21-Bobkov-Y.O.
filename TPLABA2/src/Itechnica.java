import java.awt.Graphics;
import java.awt.Color;

public interface Itechnica 
{
	    void drawSamolet(Graphics g);
		void moveSamolet(Graphics g);
		void setPosition(int x, int y);
		void loadVzletMass(int count);
        int getVzletMass();
        void setMainColor(Color color);
		String getInfo();
}
