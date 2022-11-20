namespace DocumentModel.Spreadsheet;

/// <summary>
/// Merged Cell.
/// </summary>
public interface IMergeCell // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? Reference { get ; set; }
  
}
