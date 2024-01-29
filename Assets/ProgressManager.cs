using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ProgressManager : MonoBehaviour
{
    public TMP_Text totalRating;
    public TMP_Text username;
    public TMP_Text nounwrong;
    public TMP_Text pronounwrong;
    public TMP_Text verbwrong;
    public TMP_Text adverbwrong;
    public TMP_Text adjectiveswrong;
    public TMP_Text prepositionwrong;
    public TMP_Text conjunctionwrong;
    public TMP_Text interjectionwrong;
    public TMP_Text simplepresenttensewrong;
    public TMP_Text simplepasttensewrong;
    public TMP_Text simplefuturetensewrong;
    public TMP_Text presentcontinuoustensewrong;
    public TMP_Text pastcontinuoustensewrong;
    public TMP_Text presentperfecttensewrong;
    public TMP_Text pastperfecttensewrong;
    public TMP_Text futureperfecttensewrong;
    public TMP_Text modalverbswrong;
    public TMP_Text sentenceswrong;
    public TMP_Text articleswrong;
    public TMP_Text punctuationwrong;
    public TMP_Text subverbagreementwrong;
    public TMP_Text gerundswrong;
    public progressTab ratings;
    public progressTab correct;
    public progressTab wrong;
    public UserManager um;
    public GameObject YesNoDialog;
    public void setmistakerecords() 
    {

        UpdateTextColors(um.activeUser.score.nounWrong, um.activeUser.score.pronounWrong, um.activeUser.score.verbWrong);
        UpdateTextColors(um.activeUser.score.adverbWrong, um.activeUser.score.adjectivesWrong, um.activeUser.score.prepositionWrong);
        UpdateTextColors(um.activeUser.score.conjunctionWrong, um.activeUser.score.interjectionWrong, um.activeUser.score.simplepresenttenseWrong);
        UpdateTextColors(um.activeUser.score.simplepasttenseWrong, um.activeUser.score.simplefuturetenseWrong, um.activeUser.score.presentcontinuoustenseWrong);
        UpdateTextColors(um.activeUser.score.pastcontinuoustenseWrong, um.activeUser.score.presentcontinuoustenseWrong, um.activeUser.score.pastcontinuoustenseWrong);
        UpdateTextColors(um.activeUser.score.presentperfecttenseWrong, um.activeUser.score.pastperfecttenseWrong, um.activeUser.score.futureperfecttenseWrong);
        UpdateTextColors(um.activeUser.score.modalverbsWrong, um.activeUser.score.sentencesWrong, um.activeUser.score.articlesWrong);
        UpdateTextColors(um.activeUser.score.punctuationWrong, um.activeUser.score.subverbagreementWrong, um.activeUser.score.gerundsWrong);
    }
    void UpdateTextColors(int num1, int num2, int num3)
    {
        int[] nums = { num1, num2, num3 };
        System.Array.Sort(nums);

        // Check for equality
        if (nums[0] == nums[2])
        {
            SetTextColor(nounwrong, Color.white);
            SetTextColor(pronounwrong, Color.white);
            SetTextColor(verbwrong, Color.white);
            SetTextColor(adverbwrong, Color.white);
            SetTextColor(adjectiveswrong, Color.white);
            SetTextColor(prepositionwrong, Color.white);
            SetTextColor(conjunctionwrong, Color.white);
            SetTextColor(interjectionwrong, Color.white);
            SetTextColor(simplepresenttensewrong, Color.white);
            SetTextColor(simplepasttensewrong, Color.white);
            SetTextColor(simplefuturetensewrong, Color.white);
            SetTextColor(presentcontinuoustensewrong, Color.white);
            SetTextColor(pastcontinuoustensewrong, Color.white);
            SetTextColor(presentperfecttensewrong, Color.white);
            SetTextColor(pastperfecttensewrong, Color.white);
            SetTextColor(futureperfecttensewrong, Color.white);
            SetTextColor(modalverbswrong, Color.white);
            SetTextColor(sentenceswrong, Color.white);
            SetTextColor(articleswrong, Color.white);
            SetTextColor(punctuationwrong, Color.white);
            SetTextColor(subverbagreementwrong, Color.white);
            SetTextColor(gerundswrong, Color.white);
        }
        else if (nums[0] == nums[1] && nums[1] < nums[2])
        {
            SetTextColor(nounwrong, Color.red);
            SetTextColor(pronounwrong, Color.red);
            SetTextColor(verbwrong, Color.red);
            SetTextColor(adverbwrong, Color.red);
            SetTextColor(adjectiveswrong, Color.red);
            SetTextColor(prepositionwrong, Color.red);
            SetTextColor(conjunctionwrong, Color.red);
            SetTextColor(interjectionwrong, Color.red);
            SetTextColor(simplepresenttensewrong, Color.red);
            SetTextColor(simplepasttensewrong, Color.red);
            SetTextColor(simplefuturetensewrong, Color.red);
            SetTextColor(presentcontinuoustensewrong, Color.red);
            SetTextColor(pastcontinuoustensewrong, Color.red);
            SetTextColor(presentperfecttensewrong, Color.red);
            SetTextColor(pastperfecttensewrong, Color.red);
            SetTextColor(futureperfecttensewrong, Color.red);
            SetTextColor(modalverbswrong, Color.red);
            SetTextColor(sentenceswrong, Color.red);
            SetTextColor(articleswrong, Color.red);
            SetTextColor(punctuationwrong, Color.red);
            SetTextColor(subverbagreementwrong, Color.red);
            SetTextColor(gerundswrong, Color.green);
        }
        else if (nums[1] == nums[2] && nums[0] < nums[1])
        {
            SetTextColor(nounwrong, Color.green);
            SetTextColor(pronounwrong, Color.red);
            SetTextColor(verbwrong, Color.red);
            SetTextColor(adverbwrong, Color.red);
            SetTextColor(adjectiveswrong, Color.red);
            SetTextColor(prepositionwrong, Color.red);
            SetTextColor(conjunctionwrong, Color.red);
            SetTextColor(interjectionwrong, Color.red);
            SetTextColor(simplepresenttensewrong, Color.red);
            SetTextColor(simplepasttensewrong, Color.red);
            SetTextColor(simplefuturetensewrong, Color.red);
            SetTextColor(presentcontinuoustensewrong, Color.red);
            SetTextColor(pastcontinuoustensewrong, Color.red);
            SetTextColor(presentperfecttensewrong, Color.red);
            SetTextColor(pastperfecttensewrong, Color.red);
            SetTextColor(futureperfecttensewrong, Color.red);
            SetTextColor(modalverbswrong, Color.red);
            SetTextColor(sentenceswrong, Color.red);
            SetTextColor(articleswrong, Color.red);
            SetTextColor(punctuationwrong, Color.red);
            SetTextColor(subverbagreementwrong, Color.red);
            SetTextColor(gerundswrong, Color.red);
        }
        else
        {
            SetTextColor(nounwrong, Color.green);
            SetTextColor(pronounwrong, Color.yellow);
            SetTextColor(verbwrong, Color.red);
            SetTextColor(adverbwrong, Color.green);
            SetTextColor(adjectiveswrong, Color.yellow);
            SetTextColor(prepositionwrong, Color.red);
            SetTextColor(conjunctionwrong, Color.green);
            SetTextColor(interjectionwrong, Color.yellow);
            SetTextColor(simplepresenttensewrong, Color.red);
            SetTextColor(simplepasttensewrong, Color.green);
            SetTextColor(simplefuturetensewrong, Color.yellow);
            SetTextColor(presentcontinuoustensewrong, Color.red);
            SetTextColor(pastcontinuoustensewrong, Color.green);
            SetTextColor(presentperfecttensewrong, Color.yellow);
            SetTextColor(pastperfecttensewrong, Color.red);
            SetTextColor(futureperfecttensewrong, Color.green);
            SetTextColor(modalverbswrong, Color.yellow);
            SetTextColor(sentenceswrong, Color.red);
            SetTextColor(articleswrong, Color.green);
            SetTextColor(punctuationwrong, Color.yellow);
            SetTextColor(subverbagreementwrong, Color.red);
            SetTextColor(gerundswrong, Color.green);
        }

        // Update text values
        nounwrong.text = "NOUN";
        pronounwrong.text = "PRONOUN";
        verbwrong.text = "VERB";
        adverbwrong.text = "ADVERB";
        adjectiveswrong.text = "ADJECTIVES";
        prepositionwrong.text = "PREPOSITION";
        conjunctionwrong.text = "CONJUNCTION";
        interjectionwrong.text = "INTERJECTION";
        simplepresenttensewrong.text = "SIMPLE PRESENT TENSE";
        simplepasttensewrong.text = "SIMPLE PAST TENSE";
        simplefuturetensewrong.text = "SIMPLE FUTURE TENSE";
        presentcontinuoustensewrong.text = "PRESENT CONTINUOUS TENSE";
        pastcontinuoustensewrong.text = "PAST CONTINUOUS TENSE";
        presentperfecttensewrong.text = "PRESENT PERFECT TENSE";
        pastperfecttensewrong.text = "PAST PERFECT TENSE";
        futureperfecttensewrong.text = "FUTURE PERFECT TENSE";
        modalverbswrong.text = "MODAL VERBS";
        sentenceswrong.text = "SENTENCES";
        punctuationwrong.text = "PUNCTUATIONS";
        subverbagreementwrong.text = "SUBJECT & VERB AGREEMENT";
        gerundswrong.text = "GERUNDS & INFINITIVES";
    }
    void SetTextColor(TMP_Text text, Color color)
    {
        text.color = color;
    }
    public void setProgress() 
    {
        setmistakerecords();
        //calculating the variables of player's progress
        int easycorrect = um.activeUser.score.easyRight;
        int easywrong = um.activeUser.score.easyWrong;
        int medcorrect = um.activeUser.score.mediumRight;
        int medwrong = um.activeUser.score.mediumWrong;
        int hardcorrect = um.activeUser.score.hardRight;
        int hardwrong = um.activeUser.score.hardWrong;
        int allcorrect = easycorrect + medcorrect + hardcorrect;
        int allwrong = easywrong + medwrong + hardwrong;
        float totalrating= (allcorrect + allwrong > 0) ? ((float)allcorrect / (allcorrect + allwrong)) * 100 : 0;
        float rateEasy = (easycorrect + easywrong > 0) ? ((float)easycorrect / (easycorrect + easywrong)) * 100 : 0;
        float rateMed= (medcorrect + medwrong > 0) ? ((float)medcorrect / (medcorrect + medwrong)) * 100 : 0;
        float rateHard= (hardcorrect + hardwrong > 0) ? ((float)hardcorrect / (hardcorrect + hardwrong)) * 100 : 0;
        //display the calculation for progress

        //total rating
        username.text = um.activeUser.username;
        totalRating.text = totalrating.ToString("0")+"%";
        //difficulty ratings
        ratings.easy.text = rateEasy.ToString("0") + "%";
        ratings.medium.text = rateMed.ToString("0") + "%";
        ratings.hard.text = rateHard.ToString("0") + "%";
        // difficulty corrects
        correct.easy.text = easycorrect.ToString("0") + "";
        correct.medium.text = medcorrect.ToString("0") + "";
        correct.hard.text = hardcorrect.ToString("0") + "";
        //difficulty wrongs
        wrong.noun.text = um.activeUser.score.nounWrong.ToString("0") + "";
        wrong.pronoun.text = um.activeUser.score.pronounWrong.ToString("0") + "";
        wrong.verb.text = um.activeUser.score.verbWrong.ToString("0") + "";
        wrong.adverb.text = um.activeUser.score.adverbWrong.ToString("0") + "";
        wrong.adjectives.text = um.activeUser.score.adjectivesWrong.ToString("0") + "";
        wrong.preposition.text = um.activeUser.score.prepositionWrong.ToString("0") + "";
        wrong.conjunction.text = um.activeUser.score.conjunctionWrong.ToString("0") + "";
        wrong.interjection.text = um.activeUser.score.interjectionWrong.ToString("0") + "";
        wrong.simplepresenttense.text = um.activeUser.score.simplepresenttenseWrong.ToString("0") + "";
        wrong.simplepasttense.text = um.activeUser.score.simplepasttenseWrong.ToString("0") + "";
        wrong.simplefuturetense.text = um.activeUser.score.simplefuturetenseWrong.ToString("0") + "";
        wrong.presentcontinuoustense.text = um.activeUser.score.presentcontinuoustenseWrong.ToString("0") + "";
        wrong.pastcontinuoustense.text = um.activeUser.score.pastcontinuoustenseWrong.ToString("0") + "";
        wrong.presentperfecttense.text = um.activeUser.score.presentperfecttenseWrong.ToString("0") + "";
        wrong.pastperfecttense.text = um.activeUser.score.pastperfecttenseWrong.ToString("0") + "";
        wrong.futureperfecttense.text = um.activeUser.score.futureperfecttenseWrong.ToString("0") + "";
        wrong.modalverbs.text = um.activeUser.score.modalverbsWrong.ToString("0") + "";
        wrong.sentences.text = um.activeUser.score.sentencesWrong.ToString("0") + "";
        wrong.punctuation.text = um.activeUser.score.punctuationWrong.ToString("0") + "";
        wrong.subverbagreement.text = um.activeUser.score.subverbagreementWrong.ToString("0") + "";
        wrong.gerunds.text = um.activeUser.score.gerundsWrong.ToString("0") + "";

    }
    public void deletedata() 
    {
        ConfirmationDialog dialog = Instantiate(YesNoDialog).GetComponent<ConfirmationDialog>();

        // Show a message in the dialog
        dialog.Show("Deleting all user accounts, quizzes, and scores are cannot be retrieved. Confirm?");

        // Check the result of the dialog
        StartCoroutine(WaitForConfirmationAndRemove(dialog));
    }
    private IEnumerator WaitForConfirmationAndRemove(ConfirmationDialog dialog)
    {
        while (!dialog.GetConfirmationResult())
        {
            yield return null; // Wait for user input
        }

        // Process removal based on the confirmation result
        if (dialog.GetConfirmationResult())
        {
            DataSaver.DeleteData();
            Application.Quit();
        }

        // Destroy the dialog
        Destroy(dialog.gameObject);
    }
}
