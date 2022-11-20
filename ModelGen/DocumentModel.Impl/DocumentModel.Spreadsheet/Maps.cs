namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Maps Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IMeasureDimensionMap))]
public class Maps: IMaps
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
