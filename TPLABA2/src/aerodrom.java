import java.io.Serializable;
import java.util.Dictionary;
import java.util.Hashtable;
import java.util.Iterator;


public class aerodrom <T extends Itechnica> implements Serializable, Iterable<T>, Iterator<T>, Comparable<aerodrom<T>> {
	private Dictionary<Integer, T> places;
	int maxCount;
	private T defaultValue;

	public aerodrom(int size, T defVal)
	{
		places = new Hashtable<Integer, T>();
		maxCount = size;
	}
	
	public static <T extends Itechnica> int plus(aerodrom<T> p, T samolet) throws ParkingOverflowException, ParkingAlreadyHaveException
	{
		boolean isSamolet = samolet instanceof frontovoibombardir;
		if (p.places.size() == p.maxCount) throw new ParkingOverflowException();
		int index = p.places.size();
		for(int i = 0; i < p.places.size(); i++)
		{
			if (p.checkFree(i))
			{
				index = i;
				if (samolet.getClass() == p.places.get(i).getClass()) {
					 				if (isSamolet) {
					 					if (((frontovoibombardir) samolet).equals(p.places.get(i))) {
					 						throw new ParkingAlreadyHaveException();
					 					}
					 				} else if (((Samolet) samolet).equals(p.places.get(i))) {
					 					throw new ParkingAlreadyHaveException();
					 				}
					  		}
			}
		}
		if (index != p.places.size()) {
			 			p.places.put(index, samolet);
			 			return index;
		}
		p.places.put(p.places.size(), samolet);
		return p.places.size() - 1;
	}

	public static <T extends Itechnica> T minus(aerodrom<T> p, int index)throws ParkingIndexOutOfRangeException
	{
		if (p.places.get(index) != null)
		{
			T samolet = p.places.get(index);
			p.places.remove(index);
			return samolet;
		}
		throw new ParkingIndexOutOfRangeException();
	}

	public boolean checkFree(int index)
	{
		if(places.get(index)==null) return true;
		return false;
	}
	
	public T getSamolet(int ind) {
		if(places.get(ind)!=null) return places.get(ind);
		return defaultValue;
	}
	@Override
	 	public Iterator<T> iterator() {
	 		return this;
	 	}
	 
	 	private int currentIndex;
	 
	 	@Override
	 	public boolean hasNext() {
	 		if (currentIndex + 1 >= places.size()) {
	 			currentIndex = -1;
	 			return false;
	 		}
	 		currentIndex++;
	 		return true;
	 	}
	 
	 	@Override
	 	public T next() {
			return (T) places.get(currentIndex);
	 	}
	 
	 	@Override
	 	public int compareTo(aerodrom<T> other) {
	 		if (places.size() > other.places.size())
	 			return -1;
	 		else if (places.size() < other.places.size())
	 			return 1;
	 		else {
	 			for (int i = 0; i < places.size(); i++) {
	 				if ((places.get(places.keys().nextElement()) instanceof frontovoibombardir)
	 						&& (other.places.get(other.places.keys().nextElement()) instanceof frontovoibombardir)) {
	 					return (((frontovoibombardir) places.get(places.keys().nextElement()))
	 							.compareTo(((frontovoibombardir) other.places.get(other.places.keys().nextElement()))));
	 				}
	 				if ((places.get(places.keys().nextElement()) instanceof Samolet)
	 						&& (other.places.get(other.places.keys().nextElement()) instanceof frontovoibombardir))
	 					return 1;
	 				if ((places.get(places.keys().nextElement()) instanceof frontovoibombardir)
	 						&& (other.places.get(other.places.keys().nextElement()) instanceof Samolet))
	 					return -1;
	 				if ((places.get(places.keys().nextElement()) instanceof Samolet)
	 						&& (other.places.get(other.places.keys().nextElement()) instanceof Samolet)) {
	 					return (((Samolet) places.get(places.keys().nextElement()))
	 							.compareTo(((Samolet) other.places.get(other.places.keys().nextElement()))));
	 				}
	 
	 			}
	 		}
	 		return 0;
	 	}
	 
}