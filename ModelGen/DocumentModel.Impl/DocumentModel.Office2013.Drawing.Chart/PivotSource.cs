namespace DocumentModel.Office2013.Drawing.Chart;

/// <summary>
/// Defines the PivotSource Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IFormatId))]
[ChildElementInfo(typeof(DocumentModel.Drawing.Charts.IPivotTableName))]
public class PivotSource: IPivotSource
{
  /// <summary>
  /// Pivot Name.
  /// </summary>
  public IPivotTableName? PivotTableName
  {
    get;
    set;
  }
  
  /// <summary>
  /// Format ID.
  /// </summary>
  public IFormatId? FormatId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Chart Extensibility.
  /// </summary>
  public DocumentModel.Drawing.Charts.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
