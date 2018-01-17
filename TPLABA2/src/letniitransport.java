import java.awt.Color;
import java.awt.Graphics;

public abstract class letniitransport implements Itechnica {

	protected int startPosX;
	protected int startPosY;
	protected int countVzletMass;
	public int maxcountVzletMass;
	public int maxSpeed;
	public int weight;
	transient  public Color colorBody;

	protected abstract void setmaxSpeed(int s);

	public abstract int getmaxSpeed();

	protected abstract void setweight(int w);

	public abstract int getweight();

	protected abstract void setmaxcountVzletMass(int c);

	public abstract int getmaxcountVzletMass();

	public abstract void moveSamolet(Graphics g);

	public abstract void drawSamolet(Graphics g);

	public void SetPosition(int x, int y) {
		startPosX = x;
		startPosY = y;
	}
	public void loadVzletMass(int count)
    {
        if (countVzletMass + count < maxcountVzletMass)
        {
            countVzletMass += count;
        }
    }
    public int getVzletMass()
    {
        int count = countVzletMass;
        countVzletMass = 0;
        return count;
    }
    public void setMainColor(Color c) {
    	colorBody = c;
    }
    public abstract String getInfo();
}
