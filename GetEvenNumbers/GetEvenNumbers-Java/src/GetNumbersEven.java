import java.util.List;
import java.util.Vector;


public class GetNumbersEven {

	public GetNumbersEven() 
	{
		
	}
	public static Integer[] GetRes(Integer[] arr)
	{
		List<Integer> res = new Vector<Integer>();
		for(Integer i = 0; i < arr.length; i++)
		{
			if (((arr[i] & 1) == 0))
			{
			   res.add(arr[i]);
			}
		}
		return res.toArray(new Integer[res.size()]);
	}

	public static void main(String[] args)
	{
		Integer[] test = new Integer[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};  
		Integer[] res = GetNumbersEven.GetRes(test);
		for(int i = 0; i < res.length; i++)
		{
			System.out.println(res[i]);
		}
		

	}

}
