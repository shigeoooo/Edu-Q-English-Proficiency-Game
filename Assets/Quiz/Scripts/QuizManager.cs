using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class QuizManager : MonoBehaviour
{
    public scriptableQuiz sq;
    public ChooseCategory cc;
    public quizes SetOfQuiz;
    public BoxedMessage message;
    public PanelManager pm;
    private void Start()
    {
        SetOfQuiz = DataSaver.LoadQuiz(SetOfQuiz);
    }
    public void loadQuizes(bool exercise)
    {
        cc.exercise = exercise;
        if (!exercise)
        {
            
            SetOfQuiz = DataSaver.LoadQuiz(SetOfQuiz);
           
            Debug.Log("Quiz Mode");
            
        }
        else 
        {
            Debug.Log("Exercise Mode");
            SetOfQuiz = sq.dataquiz;
            
        }
        try 
        {
            if (AreArraysEnough(SetOfQuiz.identifications,1) && AreArraysEnough(SetOfQuiz.MultipleChoices,1))
            {
                pm.ChangeSection(2);
               
            }
            else
            {
                message.Message.text = "No quizzes yet. Waiting for a teacher to create one.";
                GameObject msg = Instantiate(message.gameObject);
            }
        }
        catch 
        {
            message.Message.text = "No quizzes yet. Waiting for a teacher to create one.";
            GameObject msg = Instantiate(message.gameObject);
        }
        // Check if both identifications and MultipleChoices are completely empty
        
    }

    // Helper method to check if an array is empty
    private bool AreArraysEnough(DifficultyIdentification arrays, int range)
    {
        return arrays.easy.Length >= range && arrays.medium.Length >= range && arrays.hard.Length >= range;
    }

    // Helper method to check if an array is empty
    private bool AreArraysEnough(DifficultyMultiple arrays, int range)
    {
        return arrays.easy.Length >= range && arrays.medium.Length >= range && arrays.hard.Length >= range;
    }



}

[System.Serializable]
public class quizes
{
    public DifficultyIdentification identifications;
    public DifficultyMultiple MultipleChoices;

}
[System.Serializable]
public class Identification
{
    [TextArea(10, 20)]
    public string description;
    public int topic; //0 = phrase, 1 = plurals, 2 = idioms
    public string rightAnswer;
    [TextArea(10, 20)]
    public string Explanation;
    public UserInfo author;
}
[System.Serializable]
public class MultipleChoice
{
    [TextArea(10, 20)]
    public string description;
    [TextArea(10, 20)]
    public string Explanation;
    public int topic; //0 = phrase, 1 = plurals, 2 = idioms
    public string choice1;
    public string choice2;
    public string choice3;
    public string choice4;
    public int rightAns;
    public UserInfo author;
}
[System.Serializable]
public class DifficultyIdentification
{
    public Identification[] easy;
    public Identification[] medium;
    public Identification[] hard;
}
[System.Serializable]
public class DifficultyMultiple
{
    public MultipleChoice[] easy;
    public MultipleChoice[] medium;
    public MultipleChoice[] hard;
}