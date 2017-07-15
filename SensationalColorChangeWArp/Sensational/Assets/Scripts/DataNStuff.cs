using UnityEngine;
using System.Collections;
using System.IO;

[System.Serializable]

public class DataNStuff : MonoBehaviour 
{

    
    // Time taken data
    //combines both time spent in stopped time and normal time

    [SerializeField]
    public float TotalTime = 0;

    [SerializeField]
    public float TimeInRoom1 = 0;

    [SerializeField]
    public float TimeInRoom2 = 0;

    [SerializeField]
    public float TimeInRoom3 = 0;

    [SerializeField]
    public float TimeInRoom4 = 0;

    [SerializeField]
    public float TimeInRoom5 = 0;

    [SerializeField]
    public float TimeInRoom6 = 0;

    [SerializeField]
    public float TimeInRoom7 = 0;

    //amount of time in stopped time data;

    [SerializeField]
    public float TotalStoppedTime = 0;

    [SerializeField]
    public float StoppedTimeInRoom1 = 0;

    [SerializeField]
    public float StoppedTimeInRoom2 = 0;

    [SerializeField]
    public float StoppedTimeInRoom3 = 0;

    [SerializeField]
    public float StoppedTimeInRoom4 = 0;

    [SerializeField]
    public float StoppedTimeInRoom5 = 0;

    [SerializeField]
    public float StoppedTimeInRoom6 = 0;

    [SerializeField]
    public float StoppedTimeInRoom7 = 0;

    //amount of time spent in normal time

    [SerializeField]
    public float TotalNormalTime = 0;

    [SerializeField]
    public float NormalTimeInRoom1 = 0;

    [SerializeField]
    public float NormalTimeInRoom2 = 0;

    [SerializeField]
    public float NormalTimeInRoom3 = 0;

    [SerializeField]
    public float NormalTimeInRoom4 = 0;

    [SerializeField]
    public float NormalTimeInRoom5 = 0;

    [SerializeField]
    public float NormalTimeInRoom6 = 0;

    [SerializeField]
    public float NormalTimeInRoom7 = 0;



    //Total shots fired data

    [SerializeField]
    public int TotalShotsFired = 0;

    [SerializeField]
    public int ShotsFiredInRoom1 = 0;

    [SerializeField]
    public int ShotsFiredInRoom2 = 0;

    [SerializeField]
    public int ShotsFiredInRoom3 = 0;

    [SerializeField]
    public int ShotsFiredInRoom4 = 0;

    [SerializeField]
    public int ShotsFiredInRoom5 = 0;

    [SerializeField]
    public int ShotsFiredInRoom6 = 0;

    [SerializeField]
    public int ShotsFiredInRoom7 = 0;

    //time stop data

    [SerializeField]
    public int TotalTimesTimeStopped = 0;

    [SerializeField]
    public int TimesTimeStoppedInRoom1 = 0;

    [SerializeField]
    public int TimesTimeStoppedInRoom2 = 0;

    [SerializeField]
    public int TimesTimeStoppedInRoom3 = 0;

    [SerializeField]
    public int TimesTimeStoppedInRoom4 = 0;

    [SerializeField]
    public int TimesTimeStoppedInRoom5 = 0;

    [SerializeField]
    public int TimesTimeStoppedInRoom6 = 0;

    [SerializeField]
    public int TimesTimeStoppedInRoom7 = 0;

    //hazard data
    //there are projectiles in room 3-7
    //there are block hazards in room 5 and 7

    [SerializeField]
    public int TotalTimesHitByAnyHazard = 0;

    //projectile hazard data

    [SerializeField]
    public int TotalTimesHitByProjectiles = 0;

    [SerializeField]
    public int TimesHitByProjectilesInRoom3 = 0;

    [SerializeField]
    public int TimesHitByProjectilesInRoom4 = 0;

    [SerializeField]
    public int TimesHitByProjectilesInRoom5 = 0;

    [SerializeField]
    public int TimesHitByProjectilesInRoom6 = 0;

    [SerializeField]
    public int TimesHitByProjectilesInRoom7 = 0;

    //block hazard data

    [SerializeField]
    public int TotalTimesHitByBlocks = 0;

    [SerializeField]
    public int TimesHitByBlocksInRoom5 = 0;

    [SerializeField]
    public int TimesHitByBlocksInRoom7 = 0;
    
    //Puzzle Resets of stuff

    [SerializeField]
    public int TotalOrbResets = 0;

    [SerializeField]
    public int OrbResetsInRoom2 = 0;

    [SerializeField]
    public int OrbResetsInRoom3 = 0;

    [SerializeField]
    public int OrbResetsInRoom4 = 0;

    [SerializeField]
    public int OrbResetsInRoom5 = 0;

    [SerializeField]
    public int OrbResetsInRoom6 = 0;

    [SerializeField]
    public int OrbResetsInRoom7 = 0;


    // Use this for initialization
    void Start ()
    {
	    //everything should start initialized at zero.
        //shooting the final switch should save and export all the data, starting a new session with everything at zero
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        UpdateTotalTimesTimeStopped();
        UpdateShotsFiredData();
        UpdateTotalTimeTaken();
        UpdateTotalOrbResets();
        UpdateTotalProjectileData();
        UpdateTotalBlockData();
        UpdateTotalHazardData();
        UpdateTotalNormalTime();
        UpdateTotalStoppedTime();

        if(Input.GetKeyDown(KeyCode.G))
        {
            TotallyLegitData();
        }
	}

    public void UpdateTotalOrbResets()
    {
        TotalOrbResets = OrbResetsInRoom2 + OrbResetsInRoom3 + OrbResetsInRoom4 + OrbResetsInRoom5
            + OrbResetsInRoom6 + OrbResetsInRoom7;
    }

    //TIME STOP data functions go here
    //updates total time stop numbers
    public void UpdateTotalTimesTimeStopped()
    {
        TotalTimesTimeStopped = TimesTimeStoppedInRoom1 + TimesTimeStoppedInRoom2 + TimesTimeStoppedInRoom3
            + TimesTimeStoppedInRoom4 + TimesTimeStoppedInRoom5 + TimesTimeStoppedInRoom6 + TimesTimeStoppedInRoom7;
    }

    //HAZARD UPDATE DATA GOES HERE

    public void UpdateTotalHazardData()
    {
        TotalTimesHitByAnyHazard = TotalTimesHitByProjectiles + TotalTimesHitByBlocks;
    }

    public void UpdateTotalProjectileData()
    {
        TotalTimesHitByProjectiles = TimesHitByProjectilesInRoom3 + TimesHitByProjectilesInRoom4
            + TimesHitByProjectilesInRoom5 + TimesHitByProjectilesInRoom6 + TimesHitByProjectilesInRoom7;
    }

    public void UpdateTotalBlockData()
    {
        TotalTimesHitByBlocks = TimesHitByBlocksInRoom5 + TimesHitByBlocksInRoom7;
    }

    //SHOTS FIRED DATA UPDATE GOES HERE

    public void UpdateShotsFiredData()
    {
        TotalShotsFired = ShotsFiredInRoom1 + ShotsFiredInRoom2 + ShotsFiredInRoom3
            + ShotsFiredInRoom4 + ShotsFiredInRoom5 + ShotsFiredInRoom6 + ShotsFiredInRoom7;
    }

    //update TOTAL TIME TAKEN, this should be linked to the clocks in each room
    public void UpdateTotalTimeTaken()
    {
        TotalTime = TimeInRoom1 + TimeInRoom2 + TimeInRoom3 + TimeInRoom4 + TimeInRoom5
            + TimeInRoom6 + TimeInRoom7;
    }

    public void UpdateTotalNormalTime()
    {
        TotalNormalTime = NormalTimeInRoom1 + NormalTimeInRoom2 + NormalTimeInRoom3
            + NormalTimeInRoom4 + NormalTimeInRoom5 + NormalTimeInRoom6 + NormalTimeInRoom7;
    }

    public void UpdateTotalStoppedTime()
    {
        TotalStoppedTime = StoppedTimeInRoom1 + StoppedTimeInRoom2 + StoppedTimeInRoom3
            + StoppedTimeInRoom4 + StoppedTimeInRoom5 + StoppedTimeInRoom6 + StoppedTimeInRoom7;
    }

    //
    //
    //
    //THINGS TO UPDATE IN ROOM 1//////////////////////////////////////////////////////////////////11111111111111111111111111111111111
    //time spent, number of time stops, shots fired

    public void UpdateTimeInRoom1(float time)
    {
        TimeInRoom1 = time;
    }

    public void UpdateStoppedTimeInRoom1(float time)
    {
        StoppedTimeInRoom1 = time;
    }

    public void UpdateNormalTimeInRoom1(float time)
    {
        NormalTimeInRoom1 = time;
    }

    public void UpdateNumberOfTimeStopsInRoom1(int yesyesyes)
    {
        TimesTimeStoppedInRoom1 = yesyesyes;
    }

    public void UpdateNumberOfShotsInRoom1(int shots)
    {
        ShotsFiredInRoom1 = shots;
    }

    //THINGS TO UPDATE IN ROOM 2//////////////////////////////////////////////////////////////222222222222222222222222222222
    //time spent, number of time stops, shots fired2
    //number of switch resets

    public void UpdateTimeInRoom2(float time)
    {
        TimeInRoom2 = time;
    }

    public void UpdateStoppedTimeInRoom2(float time)
    {
        StoppedTimeInRoom2 = time;
    }

    public void UpdateNormalTimeInRoom2(float time)
    {
        NormalTimeInRoom2 = time;
    }

    public void UpdateNumberOfTimeStopsInRoom2(int yesyesyes)
    {
        TimesTimeStoppedInRoom2 = yesyesyes;
    }

    public void UpdateNumberOfShotsInRoom2(int shots)
    {
        ShotsFiredInRoom2 = shots;
    }

    public void UpdateNumberOfSwitchResetsInRoom2()
    {
        OrbResetsInRoom2 += 1;
    }

  // Room 3 stuff //////////////////////////////////////////////////////////////////33333333333333333333333333333333333
  //time spent, number of time stops, shots fired, switch resets, number of times hit by hazards n stuff

    public void UpdateTimeInRoom3(float time)
    {
        TimeInRoom3 = time;
    }

    public void UpdateStoppedTimeInRoom3(float time)
    {
        StoppedTimeInRoom3 = time;
    }

    public void UpdateNormalTimeInRoom3(float time)
    {
        NormalTimeInRoom3 = time;
    }

    public void UpdateNumberOfTimeStopsInRoom3(int yesyesyes)
    {
        TimesTimeStoppedInRoom3 = yesyesyes;
    }

    public void UpdateNumberOfShotsInRoom3(int shots)
    {
        ShotsFiredInRoom3 = shots;
    }

    public void UpdateNumberOfSwitchResetsInRoom3()
    {
        OrbResetsInRoom3 += 1;
    }

    public void UpdateNumberOfProjectilesThatTouchedMe()
    {

        //get the message that yo I was hit by a projectile. now check what room i'm in to increment the right thing
        if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom3 == true)
        {
            TimesHitByProjectilesInRoom3 += 1;
        }

        if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom4 == true)
        {
            TimesHitByProjectilesInRoom4 += 1;
        }

        if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom5 == true)
        {
            TimesHitByProjectilesInRoom5 += 1;
        }

        if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom6 == true)
        {
            TimesHitByProjectilesInRoom6 += 1;
        }

        if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom7 == true)
        {
            TimesHitByProjectilesInRoom7 += 1;
        }
    }

    public void UpdateNumberOfBlocksThatTouchedMe()
    {

        if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom5 == true)
        {
            TimesHitByBlocksInRoom5 += 1;
        }


        if (GameObject.Find("FPSController").GetComponent<WhatRoomAmITouching>().ImInRoom7 == true)
        {
            TimesHitByBlocksInRoom7 += 1;
        }
    }

    //room 4 stuff//////////////////////////////////////////////////////////4444444444444444444444444444444444444444444444

    public void UpdateTimeInRoom4(float time)
    {
        TimeInRoom4 = time;
    }


    public void UpdateStoppedTimeInRoom4(float time)
    {
        StoppedTimeInRoom4 = time;
    }

    public void UpdateNormalTimeInRoom4(float time)
    {
        NormalTimeInRoom4 = time;
    }

    public void UpdateNumberOfTimeStopsInRoom4(int yesyesyes)
    {
        TimesTimeStoppedInRoom4 = yesyesyes;
    }

    public void UpdateNumberOfShotsInRoom4(int shots)
    {
        ShotsFiredInRoom4 = shots;
    }

    public void UpdateNumberOfSwitchResetsInRoom4()
    {
        OrbResetsInRoom4 += 1;
    }

    //room 5 stuff /////////////5555555555555555555555555555555555555555555555555555555555555555555555555555555555555
    public void UpdateTimeInRoom5(float time)
    {
        TimeInRoom5 = time;
    }


    public void UpdateStoppedTimeInRoom5(float time)
    {
        StoppedTimeInRoom5 = time;
    }

    public void UpdateNormalTimeInRoom5(float time)
    {
        NormalTimeInRoom5 = time;
    }

    public void UpdateNumberOfTimeStopsInRoom5(int yesyesyes)
    {
        TimesTimeStoppedInRoom5 = yesyesyes;
    }

    public void UpdateNumberOfShotsInRoom5(int shots)
    {
        ShotsFiredInRoom5 = shots;
    }

    public void UpdateNumberOfSwitchResetsInRoom5()
    {
        OrbResetsInRoom5 += 1;
    }

    //room 6 stuff /////////////////////////////////////////////// 66666666666666666666666666666666666666666666666666666666
    public void UpdateTimeInRoom6(float time)
    {
        TimeInRoom6 = time;
    }


    public void UpdateStoppedTimeInRoom6(float time)
    {
        StoppedTimeInRoom6 = time;
    }

    public void UpdateNormalTimeInRoom6(float time)
    {
        NormalTimeInRoom6 = time;
    }

    public void UpdateNumberOfTimeStopsInRoom6(int yesyesyes)
    {
        TimesTimeStoppedInRoom6 = yesyesyes;
    }

    public void UpdateNumberOfShotsInRoom6(int shots)
    {
        ShotsFiredInRoom6 = shots;
    }

    public void UpdateNumberOfSwitchResetsInRoom6()
    {
        OrbResetsInRoom6 += 1;
    }

    //room 7 stuff //////////////////////////////////////////////////////// 7777777777777777777777777777777777777777777777

    public void UpdateTimeInRoom7(float time)
    {
        TimeInRoom7 = time;
    }


    public void UpdateStoppedTimeInRoom7(float time)
    {
        StoppedTimeInRoom7 = time;
    }

    public void UpdateNormalTimeInRoom7(float time)
    {
        NormalTimeInRoom7 = time;
    }

    public void UpdateNumberOfTimeStopsInRoom7(int yesyesyes)
    {
        TimesTimeStoppedInRoom7 = yesyesyes;
    }

    public void UpdateNumberOfShotsInRoom7(int shots)
    {
        ShotsFiredInRoom7 = shots;
    }

    public void UpdateNumberOfSwitchResetsInRoom7()
    {
        OrbResetsInRoom7 += 1;
    }

    public void SaveTheThing()
    {

        //check if the directory exists, if it doesnt make the save diretory. If it does gooooodo
        if (System.IO.File.Exists(Application.dataPath + "/save") == false)
        {
            Directory.CreateDirectory(Application.dataPath + "/save");
        }

        int filecount = 0;

        //Directory ThisDirectory = ;

        filecount = Directory.GetFiles(Application.dataPath + "/save").Length;

        //ok we know how many files there be, now we needt o save a new file that is the bigger

        var myFile = File.Create(Application.dataPath + "/save/DataSet" + (filecount + 1) + ".csv");
        myFile.Close();

       // myFile = File.WriteAllText(Application.dataPath + "/save/DataSet" + (filecount + 1) + ".csv", "test");
        File.WriteAllText(Application.dataPath + "/save/DataSet" + (filecount + 1) + ".csv", 
            
           TotalTime.ToString() + "," + TimeInRoom1.ToString() + "," + TimeInRoom2.ToString() + "," + 
           TimeInRoom3.ToString() + "," + TimeInRoom4.ToString() + "," + TimeInRoom5.ToString() + "," +
           TimeInRoom6.ToString() + "," + TimeInRoom7.ToString() + "," + TotalStoppedTime.ToString() + "," +
           StoppedTimeInRoom1.ToString() + "," + StoppedTimeInRoom2.ToString() + "," + StoppedTimeInRoom3.ToString() + "," +
           StoppedTimeInRoom4.ToString() + "," + StoppedTimeInRoom5.ToString() + "," + StoppedTimeInRoom6.ToString() + "," +
           StoppedTimeInRoom7.ToString() + "," + TotalNormalTime.ToString() + "," + NormalTimeInRoom1.ToString() + "," +
           NormalTimeInRoom2.ToString() + "," + NormalTimeInRoom3.ToString() + "," + NormalTimeInRoom4.ToString() + "," +
           NormalTimeInRoom5.ToString() + "," + NormalTimeInRoom6.ToString() + "," + NormalTimeInRoom7.ToString() + "," +
           TotalShotsFired.ToString() + "," + ShotsFiredInRoom1.ToString() + "," + ShotsFiredInRoom2.ToString() + "," +
           ShotsFiredInRoom3.ToString() + "," + ShotsFiredInRoom4.ToString() + "," + ShotsFiredInRoom5.ToString() + "," +
           ShotsFiredInRoom6.ToString() + "," + ShotsFiredInRoom7.ToString() + "," + TotalTimesTimeStopped.ToString() + "," +
           TimesTimeStoppedInRoom1.ToString() + "," + TimesTimeStoppedInRoom2.ToString() + "," + TimesTimeStoppedInRoom3.ToString() + "," +
           TimesTimeStoppedInRoom4.ToString() + "," + TimesTimeStoppedInRoom5.ToString() + "," + TimesTimeStoppedInRoom6.ToString() + "," +
           TimesTimeStoppedInRoom7.ToString() + "," + TotalTimesHitByAnyHazard.ToString() + "," + TotalTimesHitByProjectiles.ToString() + "," +
           TimesHitByProjectilesInRoom3.ToString() + "," + TimesHitByProjectilesInRoom4.ToString() + "," + TimesHitByProjectilesInRoom5.ToString() + "," +
           TimesHitByProjectilesInRoom6.ToString() + "," + TimesHitByProjectilesInRoom7.ToString() + "," + TotalTimesHitByBlocks.ToString() + "," +
           TimesHitByBlocksInRoom5.ToString() + "," + TimesHitByBlocksInRoom7.ToString() + "," + TotalOrbResets.ToString() + "," +
           OrbResetsInRoom2.ToString() + "," + OrbResetsInRoom3.ToString() + "," + OrbResetsInRoom4.ToString() + "," + OrbResetsInRoom5.ToString() + "," +
           OrbResetsInRoom6.ToString() + "," + OrbResetsInRoom7.ToString()
           );

    }

    public void TotallyLegitData()
    {

        StoppedTimeInRoom1 = Random.Range(0.0f, 5.6f);
        StoppedTimeInRoom2 = Random.Range(4.0f, 12.0f);
        StoppedTimeInRoom3 = Random.Range(9.0f, 20.0f);
        StoppedTimeInRoom4 = Random.Range(18.0f, 29.0f);
        StoppedTimeInRoom5 = Random.Range(22.0f, 38.0f);
        StoppedTimeInRoom6 = Random.Range(30.0f, 43.0f);
        StoppedTimeInRoom7 = Random.Range(29.0f, 50.0f);
        TotalStoppedTime = StoppedTimeInRoom1 + StoppedTimeInRoom2 + StoppedTimeInRoom3 + StoppedTimeInRoom4 + StoppedTimeInRoom5 + StoppedTimeInRoom6 + StoppedTimeInRoom7;

        NormalTimeInRoom1 = Random.Range(5.0f, 8.0f);
        NormalTimeInRoom2 = Random.Range(7.0f, 12.0f);
        NormalTimeInRoom3 = Random.Range(3.0f, 45.0f);
        NormalTimeInRoom4 = Random.Range(7.0f, 12.0f);
        NormalTimeInRoom5 = Random.Range(14.0f, 20.0f);
        NormalTimeInRoom6 = Random.Range(70.0f, 90.0f);
        NormalTimeInRoom7 = Random.Range(28.0f, 40.0f);
        TotalNormalTime = NormalTimeInRoom1 + NormalTimeInRoom2 + NormalTimeInRoom3 + NormalTimeInRoom4 + NormalTimeInRoom5 + NormalTimeInRoom6 + NormalTimeInRoom7;

        TimeInRoom1 = StoppedTimeInRoom1 + NormalTimeInRoom1;
        TimeInRoom2 = StoppedTimeInRoom2 + NormalTimeInRoom2;
        TimeInRoom3 = StoppedTimeInRoom3 + NormalTimeInRoom3;
        TimeInRoom4 = StoppedTimeInRoom4 + NormalTimeInRoom4;
        TimeInRoom5 = StoppedTimeInRoom5 + NormalTimeInRoom5;
        TimeInRoom6 = StoppedTimeInRoom6 + NormalTimeInRoom6;
        TimeInRoom7 = StoppedTimeInRoom7 + NormalTimeInRoom7;
        TotalTime = TotalStoppedTime + TotalNormalTime;

        ShotsFiredInRoom1 = Random.Range(1, 4);
        ShotsFiredInRoom2 = Random.Range(4, 10);
        ShotsFiredInRoom3 = Random.Range(8, 16);
        ShotsFiredInRoom4 = Random.Range(3, 6);
        ShotsFiredInRoom5 = Random.Range(6, 9);
        ShotsFiredInRoom6 = Random.Range(19, 30);
        ShotsFiredInRoom7 = Random.Range(10, 18);
        TotalShotsFired = ShotsFiredInRoom1 + ShotsFiredInRoom2 + ShotsFiredInRoom3 + ShotsFiredInRoom4 + ShotsFiredInRoom5 + ShotsFiredInRoom6 + ShotsFiredInRoom7;

        TimesTimeStoppedInRoom1 = Random.Range(0, 3);
        TimesTimeStoppedInRoom2 = Random.Range(1, 4);
        TimesTimeStoppedInRoom3 = Random.Range(4, 9);
        TimesTimeStoppedInRoom4 = Random.Range(4, 10);
        TimesTimeStoppedInRoom5 = Random.Range(5, 9);
        TimesTimeStoppedInRoom6 = Random.Range(19, 30);
        TimesTimeStoppedInRoom7 = Random.Range(9, 17);
        TotalTimesTimeStopped =
         TimesTimeStoppedInRoom1 +
          TimesTimeStoppedInRoom2 +
           TimesTimeStoppedInRoom3 +
            TimesTimeStoppedInRoom4 +
             TimesTimeStoppedInRoom5 +
              TimesTimeStoppedInRoom6 +
               TimesTimeStoppedInRoom7;

        TimesHitByProjectilesInRoom3 = Random.Range(2, 4);
        TimesHitByProjectilesInRoom4 = Random.Range(0, 4);
        TimesHitByProjectilesInRoom5 = Random.Range(0, 5);
        TimesHitByProjectilesInRoom6 = Random.Range(0, 6);
        TimesHitByProjectilesInRoom7 = Random.Range(0, 8);
        TotalTimesHitByProjectiles = TimesHitByProjectilesInRoom3 + TimesHitByProjectilesInRoom4 + TimesHitByProjectilesInRoom5 + TimesHitByProjectilesInRoom6 + TimesHitByProjectilesInRoom7;

        TimesHitByBlocksInRoom5 = Random.Range(0, 5);
        TimesHitByBlocksInRoom7 = Random.Range(0, 6);
        TotalTimesHitByBlocks = TimesHitByBlocksInRoom5 + TimesHitByBlocksInRoom7;

        TotalTimesHitByAnyHazard = TotalTimesHitByProjectiles + TotalTimesHitByBlocks;

        OrbResetsInRoom2 = Random.Range(0, 2);
        OrbResetsInRoom3 = Random.Range(0, 3);
        OrbResetsInRoom4 = Random.Range(0, 4);
        OrbResetsInRoom5 = Random.Range(0, 5);
        OrbResetsInRoom6 = Random.Range(0, 5);
        OrbResetsInRoom7 = Random.Range(0, 6);
        TotalOrbResets = OrbResetsInRoom2 + OrbResetsInRoom3 + OrbResetsInRoom4 + OrbResetsInRoom5 + OrbResetsInRoom6 + OrbResetsInRoom7;


        //check if the directory exists, if it doesnt make the save diretory. If it does gooooodo
        if (System.IO.File.Exists(Application.dataPath + "/save") == false)
        {
            Directory.CreateDirectory(Application.dataPath + "/save");
        }

        int filecount = 0;

        //Directory ThisDirectory = ;

        filecount = Directory.GetFiles(Application.dataPath + "/save").Length;

        //ok we know how many files there be, now we needt o save a new file that is the bigger

        var myFile = File.Create(Application.dataPath + "/save/DataSet" + (filecount + 1) + ".csv");
        myFile.Close();

        // myFile = File.WriteAllText(Application.dataPath + "/save/DataSet" + (filecount + 1) + ".csv", "test");
        File.WriteAllText(Application.dataPath + "/save/DataSet" + (filecount + 1) + ".csv",

           TotalTime.ToString() + "," + TimeInRoom1.ToString() + "," + TimeInRoom2.ToString() + "," +
           TimeInRoom3.ToString() + "," + TimeInRoom4.ToString() + "," + TimeInRoom5.ToString() + "," +
           TimeInRoom6.ToString() + "," + TimeInRoom7.ToString() + "," + TotalStoppedTime.ToString() + "," +
           StoppedTimeInRoom1.ToString() + "," + StoppedTimeInRoom2.ToString() + "," + StoppedTimeInRoom3.ToString() + "," +
           StoppedTimeInRoom4.ToString() + "," + StoppedTimeInRoom5.ToString() + "," + StoppedTimeInRoom6.ToString() + "," +
           StoppedTimeInRoom7.ToString() + "," + TotalNormalTime.ToString() + "," + NormalTimeInRoom1.ToString() + "," +
           NormalTimeInRoom2.ToString() + "," + NormalTimeInRoom3.ToString() + "," + NormalTimeInRoom4.ToString() + "," +
           NormalTimeInRoom5.ToString() + "," + NormalTimeInRoom6.ToString() + "," + NormalTimeInRoom7.ToString() + "," +
           TotalShotsFired.ToString() + "," + ShotsFiredInRoom1.ToString() + "," + ShotsFiredInRoom2.ToString() + "," +
           ShotsFiredInRoom3.ToString() + "," + ShotsFiredInRoom4.ToString() + "," + ShotsFiredInRoom5.ToString() + "," +
           ShotsFiredInRoom6.ToString() + "," + ShotsFiredInRoom7.ToString() + "," + TotalTimesTimeStopped.ToString() + "," +
           TimesTimeStoppedInRoom1.ToString() + "," + TimesTimeStoppedInRoom2.ToString() + "," + TimesTimeStoppedInRoom3.ToString() + "," +
           TimesTimeStoppedInRoom4.ToString() + "," + TimesTimeStoppedInRoom5.ToString() + "," + TimesTimeStoppedInRoom6.ToString() + "," +
           TimesTimeStoppedInRoom7.ToString() + "," + TotalTimesHitByAnyHazard.ToString() + "," + TotalTimesHitByProjectiles.ToString() + "," +
           TimesHitByProjectilesInRoom3.ToString() + "," + TimesHitByProjectilesInRoom4.ToString() + "," + TimesHitByProjectilesInRoom5.ToString() + "," +
           TimesHitByProjectilesInRoom6.ToString() + "," + TimesHitByProjectilesInRoom7.ToString() + "," + TotalTimesHitByBlocks.ToString() + "," +
           TimesHitByBlocksInRoom5.ToString() + "," + TimesHitByBlocksInRoom7.ToString() + "," + TotalOrbResets.ToString() + "," +
           OrbResetsInRoom2.ToString() + "," + OrbResetsInRoom3.ToString() + "," + OrbResetsInRoom4.ToString() + "," + OrbResetsInRoom5.ToString() + "," +
           OrbResetsInRoom6.ToString() + "," + OrbResetsInRoom7.ToString()
           );
    }



}
