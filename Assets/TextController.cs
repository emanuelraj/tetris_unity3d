using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour
{

	public Text text;
	private enum States
	{
		NightMomKilled,
		JoinsCCPD,
		StruckByLightning,
		NotHitByLightning,
		FastestManAlive,
		DiesInComa,
		BecomesFlash,
		GoesBackToSaveHisMom,
		FlashPointParadox,
		LosesPastMemory,
		ThawneTimeTravels,
		LivesHappilyWithParents, 
		WallyWestKidFlash,
		ThawneToKillMom,
		RealityAltered,
		LivesWithAlteredTL,
		DoesNotHitByLightning
		}
	;
	private States flashState;
	// Use this for initialization
	void Start ()
	{
		flashState = States.NightMomKilled;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (flashState == States.NightMomKilled) {
			nightMomKilled ();
		} else if (flashState == States.JoinsCCPD) {
			joinsCCPD ();
		} else if (flashState == States.StruckByLightning) {
			struckByLightning ();
		} else if (flashState == States.NotHitByLightning) {
			doesNotHitByLightning ();
		} else if (flashState == States.FastestManAlive) {
			fastestManAlive ();
		} else if (flashState == States.DiesInComa) {
			diesInComa ();
		} else if (flashState == States.BecomesFlash) {
			becomesFlash ();
		} else if (flashState == States.GoesBackToSaveHisMom) {
			goesBackInTime ();
		} else if (flashState == States.FlashPointParadox) {
			flashPointParadox ();
		} else if (flashState == States.LosesPastMemory) {
			losesPastMemory ();
		} else if (flashState == States.ThawneTimeTravels) {
			thawneTimeTravels ();
		} else if (flashState == States.LivesHappilyWithParents) {
			livesHappilyWithParents ();
		} else if (flashState == States.WallyWestKidFlash) {
			wallyWestKidFlash ();
		} else if (flashState == States.ThawneToKillMom) {
			thawneToKillMom ();
		} else if (flashState == States.RealityAltered) {
			realityAltered ();
		} else if (flashState == States.LivesWithAlteredTL) {
			livesWithAlteredTL ();
		} else if (flashState == States.DoesNotHitByLightning) {
			doesNotHitByLightning ();
		}
	}
	#region
	void nightMomKilled ()
	{
		text.text = "On A Fine Night when Barrys's Mom Put him in bed " +
			"for Sleep. He Wakes up in the mid of the night hearing his mom screaming" +
			"He Went down and see his mother is in the middle of Some Lightning .\n\n" +
			"Press S for Flash to Save kid Allen, K for Flash to Save his Mom";
		if (Input.GetKeyDown (KeyCode.S)) {
			flashState = States.JoinsCCPD;
		} else if (Input.GetKeyDown (KeyCode.K)) {
			flashState = States.FlashPointParadox;
		}
	}
	
	void joinsCCPD ()
	{
		text.text = "Barry Allen Joins in CCPD as Forensic Scientist to Prove his Dad is Innocent." +
			" On the Night of Partical Accelator Explosion Allen is getting ready to go on Date \n\n" +
			"Press L for Allen to be in Lab , O for Out for Date";
		if (Input.GetKeyDown (KeyCode.L)) {
			flashState = States.StruckByLightning;
		} else if (Input.GetKeyDown (KeyCode.O)) {
			flashState = States.DoesNotHitByLightning;
		}
	}
	
	void doesNotHitByLightning ()
	{
		text.text = "Allen out on Dinner Date during the time of Partical Accelator and wasn't hit by Lightning.\n\n" +
			"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {
			flashState = States.NightMomKilled;
		}
	}
	
	void struckByLightning ()
	{
		text.text = "Allen is Late for Dinner Date and was struck by lightning during the time of partical accelator explosion. " +
			"The Chemicals in the Room Affects him along with the lightning, resulting him in coma instead of being killed \n\n" +
			"Press W for Allen to Wake Up From Coma, D for Let Allen in Coma";
		if (Input.GetKeyDown (KeyCode.W)) {
			flashState = States.FastestManAlive;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			flashState = States.DiesInComa;			
		}
	}
	
	void fastestManAlive ()
	{
		text.text = "Allen wakes up from Coma and realized that he has got some power and Become Fastest Man Alive. " +
			"Barry Also Learn that he can Run Fast enought to Travel Back in Time \n\n" +
			"Press F for Allen to be Flash and Saves Earth, R for Let Runs back in time to save his Mom";
		if (Input.GetKeyDown (KeyCode.F)) {
			flashState = States.BecomesFlash;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			flashState = States.GoesBackToSaveHisMom;			
		}
	}
	
	void diesInComa ()
	{
		text.text = "Allen doesn't wakes up from Coma and Dies in Coma \n\n" +
			"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {
			flashState = States.NightMomKilled;
		}
	}
	
	void becomesFlash ()
	{
		text.text = "Allen Becomes Flash and Saves City and Earth from Evil Meta Humans \n\n" +
			"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {
			flashState = States.NightMomKilled;
		}
	}
	
	void goesBackInTime ()
	{
		text.text = "Allen decides to Run Back in Time and Save his Mom from Eobard Thawne aka Reverse Flash \n" +
			"Run Barry Run \n\n" +
			"Press R for Flash to Run Back in time to Save his Mom";
		if (Input.GetKeyDown (KeyCode.R)) {
			flashState = States.NightMomKilled;
		}
	}
	
	void flashPointParadox ()
	{
		text.text = "Allen Saves his Mom and Created All New Timeline \n" +
			"FlashPoint Paradox \n\n" +
			"Press U for Flash to use his power and Be Flash in this New Time Line, N for Not use his power, \n\n" +
			"Press R Run Back in Time To Prevent Time Line alteration";
		if (Input.GetKeyDown (KeyCode.U)) {
			flashState = States.LosesPastMemory;
		} else if (Input.GetKeyDown (KeyCode.N)) {
			flashState = States.LivesHappilyWithParents;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			flashState = States.NightMomKilled;
		}
	}
	
	void losesPastMemory ()
	{
		text.text = "Allen uses his Power to Stop Meta Humans \n\n" +
			"In the procces loses his actual life memory each time he uses his power \n\n" +
			"Press A for Flash to ask Reverse Flash to Travel Back in to kill his mom to Reset TimeLine \n" +
			"Press D for Flash not to use his power and live in the current Time Line with his Parents, \n\n";
		if (Input.GetKeyDown (KeyCode.A)) {
			flashState = States.ThawneTimeTravels;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			flashState = States.WallyWestKidFlash;
		}
	}
	
	void livesHappilyWithParents ()
	{
		text.text = "Allen Does not uses his power and Live Happily with his Parents as Barry Allen \n\n" +
			"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {
			flashState = States.NightMomKilled;
		}
	}
	
	void thawneTimeTravels ()
	{
		text.text = "Reverse Flash Time Travels to the Night and Kills Allen's Mom Again To Create New Time Line \n\n" +
			"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {
			flashState = States.NightMomKilled;
		}
	}
	
	void wallyWestKidFlash ()
	{
		text.text = "Allen doesn't Uses his Power and Let Wally West be the Flash aka Kid Flash of this TimeLine \n" +
			"Wally get Fatally Injured in an Attack with his Rival evil Flash \n" +
			"Allen Also learns the more he is in this timeline he loses his power too \n\n" +
			"Press D for Allen To Decide to Go Back in time to Reset the Timeline to Save Wally \n" +
			"Press N for Allen to Not worry About his powers and Live with his Mom";
		if (Input.GetKeyDown (KeyCode.D)) {
			flashState = States.ThawneToKillMom;
		} else if (Input.GetKeyDown (KeyCode.N)) {
			flashState = States.LivesWithAlteredTL;
		}
	}
	
	void thawneToKillMom ()
	{
		text.text = "Flash ask Reverse Flash to go back in Time to Kill his mom to Reset the Timeline \n\n" +
			"Press K for Reverse Flash to Go Back and kill Allen's mom to Reset the Timeline \n\n" +
			"Press A for Reverse Flash not to kill his mom but Alter a new Timeline";
		if (Input.GetKeyDown (KeyCode.K)) {
			flashState = States.NightMomKilled;
		} else if (Input.GetKeyDown (KeyCode.A)) {
			flashState = States.RealityAltered;
		}
	}
	
	void realityAltered ()
	{
		text.text = "Reverse Flash decided not to Kill his mom by going Back in Time so that Flash loses his Powers anyways \n\n" +
			"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {
			flashState = States.NightMomKilled;
		}
	}
	
	void livesWithAlteredTL ()
	{
		text.text = "Allen Decides to not Worry About losing his old Memory and Power and Start Living in the New Reality with his Parents \n\n" +
			"Press P to Play Again";
		if (Input.GetKeyDown (KeyCode.P)) {
			flashState = States.NightMomKilled;
		}
	}
	#endregion
}
