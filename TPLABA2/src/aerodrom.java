public class aerodrom <T extends Itechnica> {
	private T[] places;
	private T defaultValue;

	public aerodrom(int size, T defVal)
	{
		defaultValue = defVal;
		places = (T[]) new Itechnica[size];
		for(int i = 0; i < places.length; i++)
		{
			places[i] = defaultValue;
		}
	}
	
	public static <T extends Itechnica> int plus(aerodrom<T> p, T samolet)
	{
		for(int i = 0; i < p.places.length; i++)
		{
			if (p.checkFree(i))
			{
				p.places[i] = samolet;
				return i;
			}
		}
		return -1;
	}

	public static <T extends Itechnica> T minus(aerodrom<T> p, int index)
	{
		if (!p.checkFree(index))
		{
			T samolet = p.places[index];
			p.places[index] = p.defaultValue;
			return samolet;
		}
		return p.defaultValue;
	}

	public boolean checkFree(int index)
	{
		if (index < 0 || index > places.length) return false;
		if (places[index] == null) return true;
		if (places[index].equals(defaultValue)) return true;

		return false;
	}
	
	public T getObject(int index)
	{
		if (index > -1 && index < places.length) return places[index];

		return defaultValue;
	}
	
}