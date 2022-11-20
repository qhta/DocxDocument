namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataValidations Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Excel.IDataValidation))]
public class DataValidations: IDataValidations
{
  /// <summary>
  /// disablePrompts, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? DisablePrompts
  {
    get;
    set;
  }
  
  /// <summary>
  /// xWindow, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? XWindow
  {
    get;
    set;
  }
  
  /// <summary>
  /// yWindow, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? YWindow
  {
    get;
    set;
  }
  
  /// <summary>
  /// count, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
