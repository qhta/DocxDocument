namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the RangeProperties Class.
/// </summary>
public interface IRangeProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// sourceName, this property is only available in Office 2013 and later.
  /// </summary>
  public string? SourceName { get ; set; }
  
}
