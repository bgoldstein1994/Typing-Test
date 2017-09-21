using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Typing_Test
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		// Excerpts from 5 books. 3 per book.
		private string[] samples = {"He led the way between the pillars and Robert followed wordlessly, shivering in the subterranean chill. It was always cold down here. Their footsteps rang off the stones and echoed in the vault overhead as they walked among the dead of House Stark. The Lords of Winterfell watched them pass. Their likenesses were carved into the stones that sealed the tombs. In long rows they sat, blind eyes staring out into eternal darkness, while great stone direwolves curled round their feet. The shifting shadows made the stone figures seem to stir as the living passed by.",
									"Jon climbed the steps slowly, trying not to think that this might be the last time ever. Ghost padded silently beside him. Outside, snow swirled through the castle gates, and the yard was all noise and chaos, but inside the thick stone walls it was still warm and quiet. Too quiet for Jon's liking. He reached the landing and stood for a long moment, afraid. Ghost nuzzled at his hand. He took courage from that. He straightened, and entered the room.",
									"But it was no good. He had gone to the stable first, and seen his pony there in its stall, except it wasn't his pony anymore, he was getting a real horse and leaving the pony behind, and all of a sudden Bran just wanted to sit down and cry. He turned and ran off before Hodor and the other stableboys could see the tears in his eyes. That was the end of his farewells. Instead Bran spent the morning alone in the godswood, trying to teach his wolf to fetch a stick, and failing. The wolfling was smarter than any of the hounds in his father's kennel and Bran would have sworn he understood every word that was said to him, but he showed very little interest in chasing sticks.",
									"Harry moved in front of the tank and looked intently at the snake. He wouldn't have been surprised if it had died of boredom itself; no company excxept stupid people drumming their fingers on the glass trying to disturb it all day long. It was worse than having a cupboard as a bedroom, where the only visitor was Aunt Petunia hammering on the door to wake you up; at least he got to visit the rest of the house. The snake suddenly opened its beady eyes. Slowly, very slowly, it raised its head until its eyes were on a level with Harry's.",
									"But on the edge of town, drills were driven out of his mind by something else. As he sat in the usual morning traffic jam, he couldn't help noticing that there seemed to be a lot of strangely dressed people about. People in cloaks. Mr. Dursley couldn't bear people who dressed in funny clothes; the getups you saw on young people! He supposed this was some stupid new fashion. He drummed his fingers on the steering wheel and his eyes fell on a huddle of these weirdos standing quite close by. They were whispering excitedly together. Mr. Dursley was enraged to see that a couple of them weren't young at all; why, than man had to be older than he was, and wearing an emerald-green cloak! The nerve of him!",
									"A man appeared on the corner the cat had been watching, appeared so suddenly and silently you'd have though he'd just popped out of the ground. The cat's tail twitched and its eyes narrowed. Nothing like this man had ever been seen on Privet Drive. He was tall, thin, and very old, judging by the silver of his hair and beard, which were both long enough to tuck ino his belt. He was wearing long robes, a purple cloak that swept the ground and high-heeled, buckled boots. His blue eyes were light, bright, and sparkling behind half-moon spectacles and his nose was very long and crooked, as though it had been broken at least twice.",
									"So then the talk ran on; but presently it began to flag a trifle, and grow disjointed. The silences widened; the expectoration marvellously increased. Every pore inside the boys' cheeks became a spouting fountain; they could scarcely bale out the cellars under their tongues fast enough to prevent an inundation; little overflowings down their throats occurred in spite of all they could do, and sudden retchings followed every time.",
									"After breakfast his aunt took him aside, and Tom almost brightened in the hope that he was going to be flogged; but it was not so. His aunt wept over him and asked him how he could go and break her old heart so; and finally told him to go on, and ruin himself, and bring her grey hairs with sorrow to the grave, for it was no use for her to try any more. This was worse than a thousand whippings, and Tom's heart was sorer than his body. He cried, he pleaded for forgiveness, promised reform over and over again and then received his dismissal, feeling he had won but an imperfect forgiveness and established but a feeble confidence.",
									"Then her conscience reproached her, and she yearned to say something kind and loving; but she judged that this would be construed into a confession that she had been in the wrong, and discipline forbade that. So she kept silence, and went about her affairs with a troubled heart. Tom sulked in a corner and exalted his woes. He knew that in her heart his aunt was on her knees to him, and he was morosely gratified by the consciousness of it. He would hand out no signals, he would take notice of none.",
									"The eloquent voice, on which the souls of the listening audience had been borne aloft as on the swelling waves of the sea, at length came to a pause. There was a momentary silence, profound as what should follow the utterance of oracles. Then ensued a murmur and half-hushed tumult; as if the auditors, released from the high spell that had transported them into the region of another's mind, were returning into themselves, with all their awe and wonder still heavy on them. In a moment more, the crowd began to gush forth from the doors of the church.",
									"It was a circumstance to be noted, on the summer morning when our story begins its course, that the women, of whom there were several in the crowd, appeared to take a peculiar interest in whatever penal infliction might be expected to ensue. The age had not so much refinement, that any sense of impropriety restrained the wearers of petticoat and farthingale from stepping forth into the public ways, and wedging their not unsubstantial persons, if occasion were, into the throng nearest to the scaffold at an execution.",
									"The discipline of the family, in those days, was of a far more rigid kind than now. The frown, the harsh rebuke, the frequent application of the rod, enjoined by Scriptural authority, were used, not merely in the way of punishment for actual offences, but as a wholesome regimen for the growth and promotion of all childish virtues. Hester Prynne, nevertheless, the lonely mother of this one child, ran little risk of erring on the side of undue severity. Mindful, however, of her own errors and misfortunes, she early sought to impose a tender, but strict control over the infant immortality that was committed to her charge.",
									"Eragon knelt in a bed of trampled reed grass and scanned the tracks with a practiced eye. The prints told him that the deer had been in the meadow only a half-hour before. Soon they would bed down. His target, a small doe with a pronounced limp in her left forefoot, was still with the herd. He was amazed she had made it so far without a wolf or bear catching her. The sky was clear and dark, and a slight breeze stirred the air. A silvery cloud drifted over the mountains that surrounded him, its edges flowing with ruddy light cast from the harvest moon cradled between two peaks.",
									"At the glen, he strung his bow with a sure touch, then drew three arrows and nocked one, holding the others in his left hand. The moonlight revealed twenty or so motionless lumps where the deer lay in the grass. The doe he wanted was at the edge of the herd, her left foreleg stretched out awkwardly. Eragon slowly crept closer, keeping the bow ready. All his work of the past three days had led to this moment. He took a last steadying breath and-an explosion shattered the night.",
									"Nature had never polished a stone as smooth as this one. Its flawless surface was dark blue, except for thin veins of white that spiderwebbed across it. The stone was cool and frictionless under his fingers, like hardened silk. Oval and about a foot long, it weighed several pounds, though it felt lighter than it should have. Eragon found the stone both beautiful and frightening. Where did it come from? Does it have a purpose?"};

		// Book name and author for each excerpt, respectively.
		private string[] books =   {"\"A Game of Thrones\" by George R. R. Martin",
									"\"A Game of Thrones\" by George R. R. Martin",
									"\"A Game of Thrones\" by George R. R. Martin",
									"\"Harry Potter and the Sorcerer's Stone\" by J. K. Rowling",
									"\"Harry Potter and the Sorcerer's Stone\" by J. K. Rowling",
									"\"Harry Potter and the Sorcerer's Stone\" by J. K. Rowling",
									"\"The Adventures of Tom Sawyer\" by Mark Twain",
									"\"The Adventures of Tom Sawyer\" by Mark Twain",
									"\"The Adventures of Tom Sawyer\" by Mark Twain",
									"\"The Scarlet Letter\" by Nathaniel Hawthorne",
									"\"The Scarlet Letter\" by Nathaniel Hawthorne",
									"\"The Scarlet Letter\" by Nathaniel Hawthorne",
									"\"Eragon\" by Christopher Paolini",
									"\"Eragon\" by Christopher Paolini",
									"\"Eragon\" by Christopher Paolini"};

		// Word count for each excerpt, respectively.
		private int[] wordCounts = {96, 81, 131, 102, 130, 115, 69, 121, 94,
									99,	88, 107, 110, 89, 75};

		// Global timer, elapsed seconds, and current word count.
		private DispatcherTimer timer;
		private int totalSeconds = 0;
		private int currentWordCount = 0;

		private bool resetFlag = false;

		// Shuffled sample indices and current sample being tested on.
		int[] sampleOrder;
		int currentSample = 0;

		// Global accuracy value.
		double accuracy;

		public MainWindow()
		{
			InitializeComponent();

			// Shuffles the order of samples so the user doesn't type the same 
			// ones every time.
			sampleOrder = Shuffle();

			// Show the first shuffled sample.
			DisplaySample();

			// Initialize timer.
			timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal,
										Timer_Tick, Dispatcher.CurrentDispatcher)
			{
				IsEnabled = false
			};
		}

		// Event handler for user typing in the TextBox.
		private void TypingBox_TextChanged(object sender, TextChangedEventArgs e)
		{
			// Start typing test when user enters first character.
			if (!timer.IsEnabled && !resetFlag)
				StartTest();

			// Stop typing test when user has entered enough characters.
			if (TypingBox.Text.Length >= Sample.Text.Length)
				StopTest();

			UpdateWordCount();
		}

		// Event handler for the enter button being pressed.
		private void EnterPressed(object sender, KeyEventArgs e)
		{
			// Only stops test if the key pressed is Enter and the timer is
			// running.
			if (timer.IsEnabled && e.Key == Key.Enter)
				StopTest();
		}

		// This updates the timer display every second.
		private void Timer_Tick(object sender, EventArgs e)
		{
			// There's no reason a test should take an hour.
			if (Timer.Text == "59:59")
			{
				StopTest();
				return;
			}

			// Update the elapsed amount of seconds.
			totalSeconds++;

			// Extract current time in minutes and seconds from totalSeconds.
			int minutes = totalSeconds / 60;
			int seconds = totalSeconds % 60;

			// If minutes and/or seconds is less than 10, a zero is added in front.
			string minutesStr, secondsStr;
			minutesStr = minutes < 10 ? $"0{minutes}" : $"{minutes}";
			secondsStr = seconds < 10 ? $"0{seconds}" : $"{seconds}";

			// Update the timer TextBLock.
			Timer.Text = $"{minutesStr}:{secondsStr}";
		}

		// Begins timer and replaces instructions with timer display.
		private void StartTest()
		{
			// Remove instructions, display timer.
			ShowTimer();

			// Start the timer.
			timer.IsEnabled = true;
		}

		// Stops timer and display results.
		private void StopTest()
		{
			// Stop the timer.
			timer.IsEnabled = false;

			// Show user's typed passage with errors made.
			ShowErrors();

			// Cacluate words/minute.
			double speed = (double)wordCounts[sampleOrder[currentSample]] / ((double)totalSeconds / 60) * accuracy;

			// If totalSeconds is zero, then we'd get a divide by zero eroor.
			if (totalSeconds == 0)
				Speed.Text = accuracy > 0 ? "Ended too quickly =(" : "0 Words/Minute";
			else
				Speed.Text = $"{Math.Round(speed)} Words/Minute";

			// Displays results and redo button in status pane.
			AccuracyLabel.Visibility		= Visibility.Visible;
			Accuracy.Visibility				= Visibility.Visible;
			SpeedLabel.Visibility			= Visibility.Visible;
			Speed.Visibility				= Visibility.Visible;
			RedoInstructions.Visibility		= Visibility.Visible;
			Redo.Visibility					= Visibility.Visible;
		}

		// Shuffles the indices of the samples, books, and word counts.
		private int[] Shuffle()
		{
			int[] sampleOrder = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14}; 
			Random r = new Random();

			// Every element of the array gets swapped with another random
			// element of index less than or equal to its own, starting with 
			// the last element.
			for (int i=sampleOrder.Length-1; i>=0; i--)
			{
				int j = r.Next(i+1);
				int k = sampleOrder[j];
				sampleOrder[j] = sampleOrder[i];
				sampleOrder[i] = k;
			}

			return sampleOrder;
		}

		// Event listener for Redo button.
		private void Redo_Click(object sender, RoutedEventArgs e)
		{
			// If the user has taken the test 15 times already, just rotate to
			// the first excerpt again. Otherwise, move on to the next passage.
			currentSample = currentSample == 14 ? 0 : currentSample + 1;

			// Displays a new sample and resets the interface.
			DisplaySample();
			Reset();
		}

		// Displays the next sample excerpt.
		private void DisplaySample()
		{
			Sample.Text = samples[sampleOrder[currentSample]];
			Book.Text = $"     - Excerpt from {books[sampleOrder[currentSample]]}";
		}

		// Removes instructions and displays timer and word count.
		private void ShowTimer()
		{
			Instructions1.Visibility	= Visibility.Collapsed;
			Instructions2.Visibility	= Visibility.Collapsed;
			TimerLabel.Visibility		= Visibility.Visible;
			Timer.Visibility			= Visibility.Visible;
			WordsGrid.Visibility		= Visibility.Visible;
		}

		// Resets the application to original state.
		private void Reset()
		{
			// Replaces timer, word count, results, and redo button with instructions.
			TimerLabel.Visibility		= Visibility.Collapsed;
			Timer.Visibility			= Visibility.Collapsed;
			WordsGrid.Visibility		= Visibility.Collapsed;
			AccuracyLabel.Visibility	= Visibility.Collapsed;
			Accuracy.Visibility			= Visibility.Collapsed;
			SpeedLabel.Visibility		= Visibility.Collapsed;
			Speed.Visibility			= Visibility.Collapsed;
			RedoInstructions.Visibility	= Visibility.Collapsed;
			Redo.Visibility				= Visibility.Collapsed;
			TypingBoxDone.Visibility	= Visibility.Collapsed;
			TypingBox.Visibility		= Visibility.Visible;
			Instructions1.Visibility	= Visibility.Visible;
			Instructions2.Visibility	= Visibility.Visible;

			// resetFlag keeps TypingBox_TextChanged event listener from 
			// starting the timer.
			resetFlag = true;
			TypingBox.Text = "";
			resetFlag = false;

			// Reset TextBlock showing errors.
			TypingBoxDone.Text = "";

			// Reset elapsed seconds and timer display.
			Timer.Text = "00:00";
			totalSeconds = 0;
		}

		// Iterate through the sample, comparing it to the typed version for
		// accuracy.
		private void ShowErrors()
		{
			// Counter for the amount of words user typed correctly.
			int correctWords = 0;

			// Cursors for original and typed excerpts as they are traversed
			// through.
			int sampleCursor = 0, typedCursor = 0;

			// Just shortening the variable names.
			string sample = Sample.Text;
			string typed  = TypingBox.Text;

			// Current words being compared.
			string sampleWord;
			string typedWord;

			while (sampleCursor < sample.Length && typedCursor < typed.Length)
			{
				
				// Reset current words.
				sampleWord = "";
				typedWord = "";

				// Find the next word in the sample excerpt.
				while (sampleCursor < sample.Length && sample[sampleCursor] != ' ')
				{
					sampleWord += sample[sampleCursor];
					sampleCursor++;
				}

				// Point the sample cursor to the next word.
				sampleCursor++;

				// Find the next word in the typed excerpt.
				while (typedCursor < typed.Length && typed[typedCursor] != ' ')
				{
					typedWord += typed[typedCursor];
					typedCursor++;
				}

				// Point the typed cursor to the next word.
				while (typedCursor != typed.Length && typed[typedCursor] == ' ')
					typedCursor++;
		
				// Check if there's an extra word.
				if (sampleWord != typedWord)
				{
					// New variables so most recent typed word and cursor
					// aren't lost.
					string nextTypedWord = "";
					int nextTypedCursor = typedCursor;

					// Get the next typed word and point to the one after.
					while (nextTypedCursor < typed.Length && typed[nextTypedCursor] != ' ')
					{
						nextTypedWord += typed[nextTypedCursor];
						nextTypedCursor++;
					}
					while (nextTypedCursor != typed.Length && typed[nextTypedCursor] == ' ')
						nextTypedCursor++;

					// Check if there is in fact an extra word.
					if (sampleWord == nextTypedWord)
					{
						// Display which word is extra.
						TypingBoxDone.Inlines.Add(new Run { Text = typedWord, Background = Brushes.Red });
						TypingBoxDone.Inlines.Add(" ");

						// Replace the current typed word with the next one.
						typedWord = nextTypedWord;
						typedCursor = nextTypedCursor;
					}
				}

				// Check if a word was skipped.
				if (sampleWord != typedWord)
				{
					// New variables so most recent sample word and cursor
					// aren't lost.
					string nextSampleWord = "";
					int nextSampleCursor = sampleCursor;

					// Get the next sample word and point to the one after.
					while (nextSampleCursor < sample.Length && sample[nextSampleCursor] != ' ')
					{
						nextSampleWord += sample[nextSampleCursor];
						nextSampleCursor++;
					}
					nextSampleCursor++;

					// Check if a word is in fact missing
					if (typedWord == nextSampleWord)
					{
						// Display which word is missing.
						TypingBoxDone.Inlines.Add(new Run { Text = $"[\"{sampleWord}\" is missing]", Background = Brushes.Red });
						TypingBoxDone.Inlines.Add(" ");

						// Replace the current sample word with the next one.
						sampleWord = nextSampleWord;
						sampleCursor = nextSampleCursor;
					}
				}

				// Check if sample and typed words are still not the same.
				if (sampleWord != typedWord)
					TypingBoxDone.Inlines.Add(new Run { Text = typedWord, Background = Brushes.Red });

				// Check if the two words are the same.
				if (sampleWord == typedWord)
				{
					// Update correctWords count.
					correctWords++;

					// Add the word without hilighting.
					TypingBoxDone.Inlines.Add(sampleWord);
				}
				
				// Add a space after the word.
				TypingBoxDone.Inlines.Add(" ");
			}

			// Replace the typing box with a TextBlock displaying the errors.
			TypingBox.Visibility		= Visibility.Collapsed;
			TypingBoxDone.Visibility	= Visibility.Visible;

			// Calculate the accuracy based on how many words were typed
			// correctly out of the amount of words in the passage.
			accuracy = (double)correctWords / (double)wordCounts[sampleOrder[currentSample]];

			// Display the accuracy rating.
			Accuracy.Text = $"{Math.Round(100*accuracy)}%";
		}

		private void UpdateWordCount()
		{
			string[] words = TypingBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			currentWordCount = words.Length;

			if (words.Length > 0 && words[words.Length - 1] == "")
				currentWordCount--;

				Words.Text = $"{currentWordCount}";
		}
	}
}