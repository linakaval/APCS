/**
 * A program to carry on conversations with a human user.
 * This is the initial version that:  
 * <ul><li>
 *       Uses indexOf to find strings
 * </li><li>
 * 		    Handles responding to simple words and phrases 
 * </li></ul>
 * This version uses a nested if to handle default responses.
 * @author Laurie White
 * @version April 2012
 */
public class Magpie_Activity3
{
	/**
	 * Get a default greeting 	
	 * @return a greeting
	 */
	public String getGreeting()
	{
		return "Hello, let's talk.";
	}
	
	/**
	 * Gives a response to a user statement
	 * 
	 * @param statement
	 *            the user statement
	 * @return a response based on the rules given
	 */
	public String getResponse(String statement)
	{
		String response = "";
		if (findKeyword(statement, "no", 0) >= 0)
		{
			response = "Why so negative?";
		}
		else if (findKeyword(statement, "mother", 0) >= 0
				|| findKeyword(statement, "father", 0) >= 0
				|| findKeyword(statement, "sister", 0) >= 0
				|| findKeyword(statement, "brother", 0) >= 0)
		{
			response = "Tell me more about your family.";
		}
		else if (findKeyword(statement, "dog", 0) >= 0
				|| findKeyword(statement, "cat", 0) >= 0)
		{
			response = "Tell me more about your pets!";
		}
		else if (findKeyword(statement, "McKain", 0) >= 0
				|| findKeyword(statement, "Dave", 0) >= 0
				|| findKeyword(statement, "mccoon", 0) >= 0)
		{
			response = "Oh Mr. McKain? He's a terrible teacher. Just kidding.";
		}
		else if (findKeyword(statement, "phone", 0) >= 0)
		{
			response = "I can't live without my phone.";
		}
		else if (findKeyword(statement, "Nyquil", 0) >= 0
				|| findKeyword(statement, "nyquil", 0) >= 0)
		{
			response = "That's the best drug in the world. That you can take legally...";
		}
		else if (findKeyword(statement, "music", 0) >= 0)
		{
			response = "Ooooh what band do you like?";
		}
		else if (statement.trim().length() == 0)
		{
			response = "Say something, please.";
		}
		else
		{
			response = getRandomResponse();
		}
		return response;
	}

	/**
	 * Pick a default response to use if nothing else fits.
	 * @return a non-committal string
	 */
	private String getRandomResponse()
	{
		final int NUMBER_OF_RESPONSES = 6;
		double r = Math.random();
		int whichResponse = (int)(r * NUMBER_OF_RESPONSES);
		String response = "";
		
		if (whichResponse == 0)
		{
			response = "Interesting, tell me more.";
		}
		else if (whichResponse == 1)
		{
			response = "Hmmm.";
		}
		else if (whichResponse == 2)
		{
			response = "Do you really think so?";
		}
		else if (whichResponse == 3)
		{
			response = "You don't say.";
		}
		else if (whichResponse == 4)
		{
			response = "I guess.";
		}
		else if (whichResponse == 5)
		{
			response = "Oh?";
		}

		return response;
	}

	private int findKeyword(String statement, String goal, int startPos)
	{
		String phrase = statement.trim().toLowerCase();
		goal = goal.toLowerCase();
		int psn = phrase.indexOf(goal, startPos);

		while(psn >= 0)
		{
			String before = " ", after = " ";
			if(psn > 0)
			{
				before = phrase.substring(psn - 1, psn);
			}
			if (psn + goal.length() < phrase.length())
			{
				after = phrase.substring(psn + goal.length(), psn + goal.length() + 1);
			}
			/* determine the values of psn, before, and after at this point in the method */
			if (((before.compareTo("a") < 0) || (before.compareTo("z") > 0))
					&& ((after.compareTo("a") < 0) || (after.compareTo("z") > 0)))
			{
				return psn;
			}
			psn = phrase.indexOf(goal, psn + 1);
		}
		return -1;
	}
}
