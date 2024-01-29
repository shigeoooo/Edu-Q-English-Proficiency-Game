using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;


public class DataSaver
{ //this string is path where the serialized elements go
    private static readonly string userInformation = Application.persistentDataPath + "UsersInfo.Lvlpg";
    static string PathForUserInfo = userInformation;
   
    private static readonly string QuizData = Application.persistentDataPath + "QuizData.Lvlpg";
    static string PathForQuizData = QuizData;

    public static void SaveUserInfo(UserInfo[]info)
    {
        // this save the current state of list of users and serialize it
        BinaryFormatter BF = new BinaryFormatter();
        FileStream FS = new FileStream(PathForUserInfo, FileMode.Create);
        BF.Serialize(FS, info);
        FS.Close();
    }
   


    
    public static UserInfo[] LoadUser()
    {
        //this will load all saved user to display on the selection user 
        if (File.Exists(PathForUserInfo))
        {

            BinaryFormatter formater = new BinaryFormatter();
            FileStream FS = new FileStream(PathForUserInfo, FileMode.Open);
            UserInfo []data = formater.Deserialize(FS) as UserInfo[];
            FS.Close();
            return data;
        }
        else
        {
            Debug.LogError("NO FILE LOADED");
            UserInfo[] emptyUserInfo = new UserInfo[0];
            SaveUserInfo(emptyUserInfo);
            return emptyUserInfo;

        }
    }
    public static void SaveQuiz(quizes info)
    {
        //this will serialize the current state of the quizes.
        BinaryFormatter BF = new BinaryFormatter();
        FileStream FS = new FileStream(PathForQuizData, FileMode.Create);
        BF.Serialize(FS, info);
        FS.Close();
    }




    public static quizes LoadQuiz(quizes para)
    {
        // this will load all available quizes made by different teachers
        quizes data = para;

        if (File.Exists(PathForQuizData))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream FS = new FileStream(PathForQuizData, FileMode.Open);

            data = formatter.Deserialize(FS) as quizes;
            FS.Close();
        }
        else
        {
            Debug.LogError("NO FILE LOADED");
            SaveQuiz(para);
            return data;

           
        }

        return data;
    }
    public static bool DeleteData()
    {
        Debug.Log(PathForQuizData);
        bool closeapp = false;
        if (File.Exists(PathForQuizData))
        {
            File.Delete(PathForQuizData);
            Debug.Log("Progress file deleted.");
            closeapp = true;
        }

        if (File.Exists(PathForUserInfo))
        {
            File.Delete(PathForUserInfo);
            Debug.Log("Achievement file deleted.");
            closeapp = true;
        }
        return closeapp;
    }
}
[System.Serializable]
public class UserInfo
{
    // this object hold all information related to the players in this device
    public string username;
    public bool teacher;
    public string teacherPassword;
    public userScore score;
    public bool excerciseDone;

}

[System.Serializable]
public class userScore 
{
    public int easyRight;
    public int mediumRight;
    public int hardRight;
    public int easyWrong;
    public int mediumWrong;
    public int hardWrong;
    public int nounWrong;
    public int pronounWrong;
    public int verbWrong;
    public int adverbWrong;
    public int adjectivesWrong;
    public int prepositionWrong;
    public int conjunctionWrong;
    public int interjectionWrong;
    public int simplepresenttenseWrong;
    public int simplepasttenseWrong;
    public int simplefuturetenseWrong;
    public int presentcontinuoustenseWrong;
    public int pastcontinuoustenseWrong;
    public int presentperfecttenseWrong;
    public int pastperfecttenseWrong;
    public int futureperfecttenseWrong;
    public int modalverbsWrong;
    public int sentencesWrong;
    public int articlesWrong;
    public int punctuationWrong;
    public int subverbagreementWrong;
    public int gerundsWrong;
    

}
