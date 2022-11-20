namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MeasureGroups Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMeasureGroup))]
public class MeasureGroups: IMeasureGroups
{
  /// <summary>
  /// Measure Group Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
