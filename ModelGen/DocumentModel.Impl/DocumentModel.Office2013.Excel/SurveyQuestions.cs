namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the SurveyQuestions Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IQuestionsPrSurveyElementPr))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.ISurveyQuestion))]
public class SurveyQuestions: ISurveyQuestions
{
  /// <summary>
  /// QuestionsPrSurveyElementPr.
  /// </summary>
  public IQuestionsPrSurveyElementPr? QuestionsPrSurveyElementPr
  {
    get;
    set;
  }
  
}
