namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the RangeProperties Class.
/// </summary>
public class RangeProperties: IRangeProperties
{
  /// <summary>
  /// sourceName, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SourceName
  {
    get;
    set;
  }
  
}
