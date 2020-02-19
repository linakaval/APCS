import java.util.Scanner;

/**
 * A simple class to run the Magpie class.
 * @author Laurie White
 * @version April 2012
 */
public class MagpieRunner2
{

	/**
	 * Create a Magpie, give it user input, and print its replies.
	 */
	public static void main(String[] args)
	{
		System.out.println("Enter the Activity number. Choices: 2, 3, 4, 5");
		Scanner in = new Scanner (System.in);
		String choice = in.nextLine();

		switch (choice){
			case "2":
				Magpie_Activity2 maggie = new Magpie_Activity2();

				System.out.println (maggie.getGreeting());
				Scanner in2 = new Scanner (System.in);
				String statement = in2.nextLine();

				while (!statement.equals("Bye"))
				{
					System.out.println (maggie.getResponse(statement));
					statement = in.nextLine();
				}
				break;
			case "3":
		}


		//Magpie_Activity2 maggie = new Magpie_Activity2();
		
		//System.out.println (maggie.getGreeting());
		//Scanner in = new Scanner (System.in);
		//String statement = in.nextLine();
		
		//while (!statement.equals("Bye"))
		{
			//System.out.println (maggie.getResponse(statement));
			//statement = in.nextLine();
		}
	}

}
