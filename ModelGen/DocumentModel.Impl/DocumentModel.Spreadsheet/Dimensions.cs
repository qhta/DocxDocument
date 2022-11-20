namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Dimensions Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IDimension))]
public class Dimensions: IDimensions
{
  /// <summary>
  /// OLAP Dimensions Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
