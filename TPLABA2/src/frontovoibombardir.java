
import java.awt.Color;
import java.awt.Graphics;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.io.ObjectOutputStream;
import java.io.Serializable;

public class frontovoibombardir extends Samolet implements Serializable{

	private boolean raketi;
	private boolean pylimet;

	transient private Color dopColor;

	public frontovoibombardir(int maxSpeed,int maxCountVzletMass, int weight, Color color, boolean raketi, boolean pylimet,Color dopColor) {
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
	public void setdopColor(Color f) {
			dopColor = f;
	}
	private void writeObject(ObjectOutputStream s) throws IOException {
		        s.defaultWriteObject();
		        s.writeInt(colorBody.getRed());
		        s.writeInt(colorBody.getGreen());
		        s.writeInt(colorBody.getBlue());
		        s.writeInt(dopColor.getRed());
		        s.writeInt(dopColor.getGreen());
		        s.writeInt(dopColor.getBlue());
		    }
		
		    private void readObject(ObjectInputStream s) throws IOException, ClassNotFoundException {
		        s.defaultReadObject();
		        int red = s.readInt();
		        int green = s.readInt();
		        int blue = s.readInt();
		        colorBody = new Color(red, green, blue);
		        int red1 = s.readInt();
		        int green1 = s.readInt();
		        int blue1 = s.readInt();
		        dopColor = new Color(red1, green1, blue1);
		    }
		
			@Override
			public String getInfo() {
				// TODO Auto-generated method stub
		
				return maxSpeed + ";" + weight + ";" + colorBody + ";" + maxcountVzletMass + ";" + raketi + ";" + pylimet + ";"
						+ dopColor;					
		 }
			public int compareTo(frontovoibombardir other) {
				 		int res = ((Samolet) this).compareTo((Samolet) other);
				 		if (res != 0)
				 			return res;
				 		if (raketi != other.raketi)
				 			return (raketi + "").compareTo(other.raketi + "");
				 		if (pylimet != other.pylimet)
				 			return (pylimet + "").compareTo(other.pylimet + "");
				 		if (dopColor != other.dopColor)
				 			return dopColor.toString().compareTo(other.dopColor.toString());
				 		return 0;
				 	}
				 
				 	public boolean equals(frontovoibombardir other) {
				 		boolean res = ((Samolet) this).equals((Samolet) other);
				 		if (!res)
				 			return res;
				 		if (raketi != other.raketi)
				 			return false;
				 		if (pylimet != other.pylimet)
				 			return false;
				 		if (dopColor != other.dopColor)
				 			return false;
				 		return true;
				 	}
				 
				 	@Override
				 	public boolean equals(Object obj) {
				 		if (obj == null)
				 			return false;
				 		frontovoibombardir warObj = (frontovoibombardir) obj;
				 		if (warObj == null)
				 			return false;
				 		else
				 			return equals(warObj);
				 	}
}
