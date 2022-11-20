namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the DataLabelFieldTableEntry Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IDataLabelFieldTableCache))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.ITextFieldGuid))]
[ChildElementInfo(typeof(DocumentModel.Office2013.Drawing.Chart.IFormula))]
public class DataLabelFieldTableEntry: IDataLabelFieldTableEntry
{
  /// <summary>
  /// TextFieldGuid.
  /// </summary>
  public ITextFieldGuid? TextFieldGuid
  {
    get;
    set;
  }
  
  /// <summary>
  /// Formula.
  /// </summary>
  public DocumentModel.Office2013.Drawing.Chart.IFormula? Formula
  {
    get;
    set;
  }
  
  /// <summary>
  /// DataLabelFieldTableCache.
  /// </summary>
  public IDataLabelFieldTableCache? DataLabelFieldTableCache
  {
    get;
    set;
  }
  
}
