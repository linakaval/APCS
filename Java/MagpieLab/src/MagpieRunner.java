import java.util.Scanner;

/**
 * A simple class to run the Magpie class.
 * @author Laurie White
 * @version April 2012
 */
public class MagpieRunner {

	/**
	 * Create a Magpie, give it user input, and print its replies.
	 */
	public static void main(String[] args) {
		System.out.println("Enter the Activity number. Choices: 2, 3, 4, 5");
		Boolean activityNotChosen = true;
		Scanner in = new Scanner(System.in);
		String choice = in.nextLine();

		while (activityNotChosen) {
			switch (choice) {
				case "2":
					Magpie_Activity2 maggie2 = new Magpie_Activity2();

					System.out.println(maggie2.getGreeting());
					Scanner in2 = new Scanner(System.in);
					String statement2 = in2.nextLine();

					while (!statement2.equals("Bye")) {
						System.out.println(maggie2.getResponse(statement2));
						statement2 = in.nextLine();
					}
					activityNotChosen = false;
					break;
				case "3":
					Magpie_Activity3 maggie3 = new Magpie_Activity3();

					System.out.println(maggie3.getGreeting());
					Scanner in3 = new Scanner(System.in);
					String statement3 = in3.nextLine();

					while (!statement3.equals("Bye")) {
						System.out.println(maggie3.getResponse(statement3));
						statement3 = in.nextLine();
					}
					activityNotChosen = false;
					break;
				case "4":
					Magpie_Activity4 maggie4 = new Magpie_Activity4();

					System.out.println(maggie4.getGreeting());
					Scanner in4 = new Scanner(System.in);
					String statement4 = in4.nextLine();

					while (!statement4.equals("Bye")) {
						System.out.println(maggie4.getResponse(statement4));
						statement4 = in.nextLine();
					}
					activityNotChosen = false;
					break;
				case "5":
					Magpie_Activity5 maggie5 = new Magpie_Activity5();

					System.out.println(maggie5.getGreeting());
					Scanner in5 = new Scanner(System.in);
					String statement5 = in5.nextLine();

					while (!statement5.equals("Bye")) {
						System.out.println(maggie5.getResponse(statement5));
						statement5 = in.nextLine();
					}
					activityNotChosen = false;
					break;
				default:
					System.out.println("Please enter a valid number.");
					in = new Scanner(System.in);
					choice = in.nextLine();
			}
		}

	}
}
