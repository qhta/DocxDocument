namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the QuestionPrSurveyElementPr Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Excel.IExtensionList))]
public class QuestionPrSurveyElementPr: IQuestionPrSurveyElementPr
{
  /// <summary>
  /// cssClass, this property is only available in Office 2013 and later.
  /// </summary>
  public string? CssClass
  {
    get;
    set;
  }
  
  /// <summary>
  /// bottom, this property is only available in Office 2013 and later.
  /// </summary>
  public int? Bottom
  {
    get;
    set;
  }
  
  /// <summary>
  /// top, this property is only available in Office 2013 and later.
  /// </summary>
  public int? Top
  {
    get;
    set;
  }
  
  /// <summary>
  /// left, this property is only available in Office 2013 and later.
  /// </summary>
  public int? Left
  {
    get;
    set;
  }
  
  /// <summary>
  /// right, this property is only available in Office 2013 and later.
  /// </summary>
  public int? Right
  {
    get;
    set;
  }
  
  /// <summary>
  /// width, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Width
  {
    get;
    set;
  }
  
  /// <summary>
  /// height, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? Height
  {
    get;
    set;
  }
  
  /// <summary>
  /// position, this property is only available in Office 2013 and later.
  /// </summary>
  public SurveyPosition? Position
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
