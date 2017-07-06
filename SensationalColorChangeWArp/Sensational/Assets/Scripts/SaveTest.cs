using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveTest : MonoBehaviour
{

    [SerializeField]
    int TreeInt = 1;

    [SerializeField]
    float ThisIsAFloat = 1.92f;

    [SerializeField]
    double SureWhyNotADouble = 2.0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SaveTheThing();
            print("saaaaaaaaaaaaave");
        }
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

        File.Create(Application.dataPath + "/save/DataSet" + (filecount + 1) + ".csv");


    }

    private void WriteTheData(string FileName)
    {
        /*
		aipom
		umbreon
		misdreavus
		butterfree
		feraligatr? starmie?

		Directory.Exists )application.persistantdatapath + "/save")

		Directory.CeateDirectory

		if (system.io.file.exists("myfile.txt"))

		use magic while loop until we find the number of the save we wanna do

		then File.Create(datapath with save position)

		call write data function here



		in write data function

		find file i created up there, now write the things to it.

		make a string that is just straight up csv all my things.

		File.WriteAllText(Path to file, string that is the text)


		*/
    }
}
