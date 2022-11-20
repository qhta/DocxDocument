namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the SurveyQuestion Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IQuestionPrSurveyElementPr))]
public class SurveyQuestion: ISurveyQuestion
{
  /// <summary>
  /// binding, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Binding
  {
    get;
    set;
  }
  
  /// <summary>
  /// text, this property is only available in Office 2013 and later.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
  /// <summary>
  /// type, this property is only available in Office 2013 and later.
  /// </summary>
  public QuestionType? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// format, this property is only available in Office 2013 and later.
  /// </summary>
  public QuestionFormat? Format
  {
    get;
    set;
  }
  
  /// <summary>
  /// helpText, this property is only available in Office 2013 and later.
  /// </summary>
  public string? HelpText
  {
    get;
    set;
  }
  
  /// <summary>
  /// required, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Required
  {
    get;
    set;
  }
  
  /// <summary>
  /// defaultValue, this property is only available in Office 2013 and later.
  /// </summary>
  public string? DefaultValue
  {
    get;
    set;
  }
  
  /// <summary>
  /// decimalPlaces, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? DecimalPlaces
  {
    get;
    set;
  }
  
  /// <summary>
  /// rowSource, this property is only available in Office 2013 and later.
  /// </summary>
  public string? RowSource
  {
    get;
    set;
  }
  
  /// <summary>
  /// QuestionPrSurveyElementPr.
  /// </summary>
  public IQuestionPrSurveyElementPr? QuestionPrSurveyElementPr
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Office2013.Excel.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
