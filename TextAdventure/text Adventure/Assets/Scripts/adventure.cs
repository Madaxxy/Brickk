using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventure : MonoBehaviour {
    public enum States { MeetingRoom, Hallway, Bathroom, SecurityRoom, JanitorCloset, Stalls, Sink, Window,
        OutsideLedge, OverCrack, AroundCrack, MeetingRoomWindow, MeetingRoomSnackTable, ReturnToWork, ExcitingEscape }
    public States currentState;
    public Text textObject;
    public Text title;
    

    


	// Use this for initialization
	void Start () {
        currentState = States.MeetingRoom;
	}

    // Update is called once per frame
    void Update() {
        if (currentState == States.MeetingRoom)
        {
            MeetingRoom();
        }
        else if (currentState == States.Hallway)
        {
            Hallway();
        }
        else if (currentState == States.SecurityRoom)
        {
            SecurityRoom();
        }
        else if (currentState == States.JanitorCloset)
        {
            JanitorCloset();
        }
        else if (currentState == States.Bathroom)
        {
            Bathroom();
        }
        else if (currentState == States.Sink)
        {
            Sink();
        }
        else if (currentState == States.Stalls)
        {
            Stalls();
        }
        else if (currentState == States.Window)
        {
            Window();
        }
        else if (currentState == States.OutsideLedge)
        {
            OutsideLedge();
        }
        else if (currentState == States.OverCrack)
        {
            OverCrack();
        }
        else if (currentState == States.AroundCrack)
        {
            AroundCrack();
        }
        else if (currentState == States.MeetingRoomWindow)
        {
            MeetingRoomWindow();
        }
         else if (currentState == States.MeetingRoomSnackTable)
        {
            MeetingRoomSnackTable();
        }
        else if (currentState == States.ReturnToWork)
        {
            ReturnToWork();
        }
        else if (currentState == States.ExcitingEscape)
        {
            ExcitingEscape();
        }


    }
    

       private void MeetingRoom()
        {
            print("You feel your stomach rumbling, SCREAMING for a muffin.\n" +
                "the snack table is calling for you, decorated with all those colorful, decadent, beautiful muffins. \n" +
                "Your boss has said you can't have any more muffins but you disagree. \n" +
                "You have to find a way to get another muffin. \n" +
                "Suddenly an idea comes to your head .\n" +
                "press W to ask you boss to go to the bathroom. \n");
        textObject.text = "You feel your stomach rumbling, SCREAMING for a muffin.\n" +
                "the snack table is calling for you, decorated with all those colorful, delicate, beautiful muffins. \n" +
                "Your boss said you can't have any more muffins but you disagree. \n" +
                "You have to find a way to get another muffin. \n" +
                "Suddenly an idea comes to your head .\n" +
                "press W to ask you boss to go to the bathroom. \n";
        title.text = "Meeting Room";
            if (Input.GetKeyDown(KeyCode.W)) { currentState = States.Hallway; }
            
        }
    private void Hallway()
    {
        print("Your stupid boss freaking believed you! And now your in the hallway. \n" +
            "you see the entrance to the bathroom, The security room, and the Janitor Closet. \n" +
            "Press S to go to the Security room. \n" +
            "Press B to go to the Bathroom. \n" +
            "Press J to go to the Janitor Closet. \n" 
            );
        title.text = "Hallway";
        textObject.text = "Your stupid boss freaking believed you! And now your in the hallway. \n" +
            "you see the entrance to the bathroom, The security room, and the Janitor Closet. \n" +
            "Press S to go to the Security room. \n" +
            "Press B to go to the Bathroom. \n" +
            "Press J to go to the Janitor Closet. \n";
        if (Input.GetKeyDown(KeyCode.S)) { currentState = States.SecurityRoom; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.Bathroom; }
        if (Input.GetKeyDown(KeyCode.J)) { currentState = States.JanitorCloset; }

}
    private void SecurityRoom()
    {
        //create way to lose in security room.
        print(" A guard turns in his chair and spots you. 'are you trying to get those muffins?' you are going to prison. \n"
            + "you lose press space to restart");
        title.text = "Security Room";
        textObject.text = " A guard turns in his chair and spots you. 'are you trying to get those muffins?' your going to prison. \n"
            + "you lose press space to restart";
        if (Input.GetKeyDown(KeyCode.Space)) { currentState = States.MeetingRoom; }


    }
    private void JanitorCloset()
    {

        print(" What on earth is that smell? \n" +
            "OH it is probably that abnormaly large turd on the floor. \n" +
            "you slip and fall, injuring your back \n" +
            "no one comes to find you. you go muffinless for too long and die" +
            "press space to restart");
        title.text = "Janitor Closet";
        textObject.text = " What on earth is that smell? \n" +
            "OH it is probably that abnormaly large turd on the floor. \n" +
            "you slip and fall, injuring your back \n" +
            "no one comes to find you. you go muffinless for too long and die" +
            "press space to restart";
        if (Input.GetKeyDown(KeyCode.Space)) { currentState = States.MeetingRoom; }


    }
    private void Bathroom()
    {
        print("You have entered the grimey and moist bathroom that you never hoped to enter again after what happened before... \n" +
            "you see a stall, a sink and a Bathroom window. \n" +
            "Press P to go to the sink \n" +
            "Press A to look at the stall. \n" +
            "Press V to look out the window. \n");
        title.text = "Bathroom";
        textObject.text = "You have entered the grimey and moist bathroom that you never hoped to enter again after what happened before... \n" +
            "you see a stall, a sink and a Bathroom window. \n" +
            "Press P to go to the sink \n" +
            "Press A to look at the stall. \n" +
            "Press V to look out the window. \n" +
            "Press W to go back to the hallway. \n";
        if (Input.GetKeyDown(KeyCode.W)) { currentState = States.Hallway; }
        if  (Input.GetKeyDown(KeyCode.P)) { currentState = States.Sink; }
        if (Input.GetKeyDown(KeyCode.A)) { currentState = States.Stalls; }
        if (Input.GetKeyDown(KeyCode.V)) { currentState = States.Window; }
    }
    private void Sink()
    {
        print("eww this sink is rusty and there's the largest booger you've ever seen on the handle of the foset. \n" +
            "Press A to look at the stall. \n" +
            "Press V to look out the window. \n" +
            "Press B to look at the Bathroom. \n");
        title.text = "Sink";
        textObject.text = "eww this sink is rusty and there's the largest booger you've ever seen on the handle of the foset. \n" +
            "Press A to look at the stall. \n" +
            "Press V to look out the window. \n" +
            "Press B to look at the Bathroom. \n";
        if (Input.GetKeyDown(KeyCode.A)) { currentState = States.Stalls; }
        if (Input.GetKeyDown(KeyCode.V)) { currentState = States.Window; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.Bathroom; }
    }
    private void Stalls()
    {
        print("there is an poop on the lid of the toilet seat. \n" +
            "you just can't seem to figure out what is with the employees at this building.\n" +
            " They just cant seem to figure out where to poop.\n" +
            "Press P to look at the sink. \n" +
            "Press V to look out the window. \n" +
            "Press B to Go back to the Bathroom. \n");
        title.text = "Stall";
        textObject.text = "there is an poop on the lid of the toilet seat. \n" +
            "you just can't seem to figure out what is with the employees at this building.\n" +
            " They just cant seem to figure out where to poop.\n" +
            "Press P to look at the sink. \n" +
            "Press V to look out the window. \n" +
            "Press B to Go back to the Bathroom. \n";
        if (Input.GetKeyDown(KeyCode.V)) { currentState = States.Window; }
        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.Bathroom; }
        if (Input.GetKeyDown(KeyCode.P)) { currentState = States.Sink; }

    }
    private void Window()
    {
        print("you look out the window and you see that there is a ledge that you may be able to climb on to? \n" +
            "Press Y to try to climb onto the ledge. \n " +
            "Press P to look at the sink. \n" +
            "Press B to go back to the Bathroom. \n" +
            "Press A to Go back into the Stall. \n");
        title.text = "Window";
         textObject.text = "you look out the window and you see that there is a ledge that you may be able to climb on to? \n" +
            "Press Y to try to climb onto the ledge. \n " +
            "Press P to look at the sink. \n" +
            "Press B to go back to the Bathroom. \n" +
            "Press A to Go back into the Stall. \n"; 

        if (Input.GetKeyDown(KeyCode.B)) { currentState = States.Bathroom; }
        if (Input.GetKeyDown(KeyCode.P)) { currentState = States.Sink; }
        if (Input.GetKeyDown(KeyCode.Y)) { currentState = States.OutsideLedge; }
    }
    private void OutsideLedge()
    {
        print("Your standing on the ledge outside! It's very windy, you feel as if you might fall off the ledge! \n" +
            "You see a large crack in the ledge. and it is right between you and the window to the meeting room!! \n" +
            "Press K to try to jump over the crack. \n" +
            "Press O to try to try to go around the crack.");
        title.text = "Outside Ledge";
        textObject.text = "Your standing on the ledge outside! It's very windy, you feel as if you might fall off the ledge! \n" +
            "You see a large crack in the ledge. and it is right between you and the window to the meeting room!! \n" +
            "Press K to try to jump over the crack. \n" +
            "Press O to try to try to go around the crack.";
        if (Input.GetKeyDown(KeyCode.K)) { currentState = States.OverCrack; }
        if (Input.GetKeyDown(KeyCode.O)) { currentState = States.AroundCrack; }

    }
    private void OverCrack()
    {
        print("You're a daredevil. you barely made it over the crack and manage by the skin of your toes to make it."
            + "Press H to look through the window."
            );
        title.text = "Over Crack";
        textObject.text = "You're a daredevil. you barely made it over the crack and manage by the skin of your toes to make it."
            + "Press H to look through the window.";

        if (Input.GetKeyDown(KeyCode.H)) { currentState = States.MeetingRoomWindow; }
    }
    private void AroundCrack()
    {
        print (" You fall and die! what kind of stupid would try to jump around a crack on a ledge of a fifty story building? \n" +
            "press space to restart. ");
        title.text = "Around Crack";
        textObject.text = " You fall and die! what kind of stupid would try to jump around a crack on a ledge of a fifty story building? \n" +
            "press space to restart. ";
        if (Input.GetKeyDown(KeyCode.Space)) { currentState = States.MeetingRoom; }
    }
    private void MeetingRoomWindow()
    {
        print("You Look through the window and are able to see all those delicious MUFFINS! \n" +
            "Press Z to Punch through the window to get straight to the muffins.");
        title.text = "Meeting Room Window";
        textObject.text = "You Look through the window and are able to see all those delicious MUFFINS! \n" +
            "Press Z to Punch through the window to get straight to the muffins.";
        if (Input.GetKeyDown(KeyCode.Z)) { currentState = States.MeetingRoomSnackTable; }
    }
    private void MeetingRoomSnackTable()
    {
        print("you have managed to finally get your precious, precious, muffins. \n" +
            "but your misson is not quite over. \n" +
            "Press U to do a double backflip out the window and super parcour your way down the building.\n" +
            "Press Q to Return to work.");
        title.text = "Meeting Room Snack Table";
        textObject.text = "you have managed to finally get your precious, precious, muffins. \n" +
            "but your misson is not quite over. \n" +
            "Press U to do a double backflip out the window and super parcour your way down the building.\n" +
            "Press Q to Return to work.";
        if (Input.GetKeyDown(KeyCode.U)) { currentState = States.ExcitingEscape; }
        if (Input.GetKeyDown(KeyCode.Q)) { currentState = States.ReturnToWork; }

    }
    private void ReturnToWork()
    {
        print("who would just go back to work after all the trouble that you went through to just get those muffins.\n" +
            "you definately don't deserve to win. so Press space to try again");
        title.text = "Return to Work";
        textObject.text = "who would just go back to work after all the trouble that you went through to just get those muffins.\n" +
            "you definately don't deserve to win. so Press space to try again";
        if (Input.GetKeyDown(KeyCode.Space)) { currentState = States.MeetingRoom; }
    }

    private void ExcitingEscape() 
            {
                print(" You grab all the Muffins you can manage to stuff in your mouth and pockets. \n" +
                    "Your boss starts to scream profanities and fires you. \n" +
                    "but you don't care you grab the parachute that was conviently laying proped up against the window ledge. \n" +
                    "You do the coolest tripple backflip out of the window that is possible. you fall about fifty feet and pull the parachute. \n" +
                    "you land safely next to a getaway car and drive off into the great unknown with a pocket full of muffins and the sun to your back.\n" +
                    "THE END \n"+
                    "Press space to play again");
        title.text = "Exciting Escape";
        textObject.text = " You grab all the Muffins you can manage to stuff in your mouth and pockets. \n" +
                    "Your boss starts to scream profanities and fires you. \n" +
                    "but you don't care you grab the parachute that was conviently laying proped up against the window ledge. \n" +
                    "You do the coolest tripple backflip out of the window that is possible. you fall about fifty feet and pull the parachute. \n" +
                    "you land safely next to a getaway car and drive off into the great unknown with a pocket full of muffins and the sun to your back.\n" +
                    "THE END \n" +
                    "Press space to play again";
                if (Input.GetKeyDown(KeyCode.Space)) { currentState = States.MeetingRoom; }
            }


    }

    //create a way to win and to lose.





