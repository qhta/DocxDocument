namespace DocumentModel.Spreadsheet;

/// <summary>
/// Filter.
/// </summary>
public interface IFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Filter Value
  /// </summary>
  public string? Val { get ; set; }
  
}
