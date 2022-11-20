namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the WebExtension Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Excel.IFormula))]
public class WebExtension: IWebExtension
{
  /// <summary>
  /// appRef, this property is only available in Office 2013 and later.
  /// </summary>
  public string? ApplicationReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office.Excel.IFormula? Formula
  {
    get;
    set;
  }
  
}
