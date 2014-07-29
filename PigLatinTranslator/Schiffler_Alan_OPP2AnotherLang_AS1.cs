using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PigLatinTranslator
{
	public partial class frmPigLatin : Form
	{
		// -------------------------------------------------------------------------------------------------------------------------------//
		
		private static String vowelChars = "AEIOUaeiou";
		private static String vowelChars2 = "AEIOUYaeiouy";
		private static String specChars = "@ # $ % ^ & * - _ = + ` ~ | \\ < > , / 1 2 3 4 5 6 7 8 9 0 ! . ?";
		private static String[] specialCharacters = specChars.Split(' ');

		// -------------------------------------------------------------------------------------------------------------------------------//
		public frmPigLatin()
		{
			InitializeComponent();
			txtEnglish.Focus();
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			txtEnglish.Text = "";
			txtLatin.Text = "";
			txtEnglish.Focus();
		}

		private void btnTranslate_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(txtEnglish.Text))
			{
				MessageBox.Show("Please Enter A Word For The Program To Work!!");
			}
			else if (String.IsNullOrWhiteSpace(txtEnglish.Text))
			{
				MessageBox.Show("Please Enter A Word For The Program To Work!! (Not Just Blank Spaces!!)");
			}
			else
			{
				TextTranslate();
			}
		}

		private void txtEnglish_TextChanged(object sender, EventArgs e)
		{
		}

		private void TextTranslate()
		{
			String phrase = txtEnglish.Text.Trim();									// Clean-up the start and finish spaces.
			String[] wordsArray = phrase.Split(' ');								// Split words into the 'words' array.
			StringBuilder sb = new StringBuilder();

			foreach (String word in wordsArray)
			{
				String myWord = word;
				String firstLetter = myWord.Substring(0, 1);
				String lastCharacter = null;

				if (endPunct(myWord) == true)										// If there is punctuation at the end of the word, word is reassembled and put back together keeping the punctuation at the end
				{
					lastCharacter = myWord.Substring(myWord.Length - 1, 1);
					myWord = myWord.Remove(myWord.Length - 1, 1);
				}

				if (!myWord.Equals("") && !specialCharacters.Any(myWord.Contains))	// If the word is not blank - then do
				{
																					// Grab the first letter of each word

					if (vowelChars.Contains(firstLetter))							//	to the end of the word.
					{
						if (word.Equals(word.ToUpper()))
						{															// Checks if the word is all caps, if so makes way caps.
							myWord += "WAY";
						}
						else
						{
							myWord += "way";
						}
					}
					else															 // If word does not start with a vowel, remove first letter
					{                                                                // and move it to the end of the word + 'ay'
						if (!vowelChars.Contains(firstLetter))
						{
							if (word.Equals(word.ToUpper()))						 // Checks if the word is all caps, if so makes ay caps, and moves letter
							{
								myWord = createConsonant(myWord).ToUpper();
							}
							else if (firstLetter.Equals(firstLetter.ToUpper()))      //Checks to see if the first letter is a capital
							{
								myWord = createConsonant(myWord);
								myWord = myWord.Substring(0, 1).ToUpper() + myWord.Substring(1, myWord.Length - 1).ToLower();
							}
							else
							{
								myWord = createConsonant(myWord).ToLower();
							}
						}
					}
				}
				else
				{
					txtLatin.Text = "Please Enter A Word";
				}
				sb.Append(myWord + lastCharacter + " ");							// Adds all strings to stringbuilder with spaces between words
				txtLatin.Text = sb.ToString().TrimEnd(' ');							// Prints Pig Latin to screen
			}
		}

		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Getting the Index of the first Vowel & the letter y (where applicable) ------------------------------------//
		private static int GetVowelIndex(String word)
		{
			int index = 0;
			if (word.ToLower().Substring(1, word.Length - 1).Contains('y'))
			{
				for (int i = 0; i < word.Length; i++)
				{
					if (vowelChars2.Contains(word[i]))
					{
						index = i;
						break;
					}
				}
				return index;
			}
			else
			{
				for (int i = 0; i < word.Length; i++)
				{
					if (vowelChars.Contains(word[i]))
					{
						index = i;
						break;
					}
				}
				return index;
			}
		}

		// Method for word with consonant -------------------------------------------------------------------------------//
		private static String createConsonant(String word)
		{
			int vowelIndex = GetVowelIndex(word);
			String conWord = word.Substring(vowelIndex) + word.Substring(0, vowelIndex) + "ay";
			return conWord;
		}

		// Determine if word has punctuation on end ---------------------------------------------------------------------//
		private static bool endPunct(String word)
		{
			Char lastChar = System.Convert.ToChar(word.Substring(word.Length - 1, 1));

			if (Char.IsPunctuation(lastChar) == true)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}