namespace DocumentModel.Spreadsheet;

/// <summary>
/// PivotCache.
/// </summary>
public interface IPivotCache // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// PivotCache Id
  /// </summary>
  public uint? CacheId { get ; set; }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id { get ; set; }
  
}
