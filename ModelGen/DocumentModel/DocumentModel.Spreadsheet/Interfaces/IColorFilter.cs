namespace DocumentModel.Spreadsheet;

/// <summary>
/// Color Filter Criteria.
/// </summary>
public interface IColorFilter // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Differential Format Record Id
  /// </summary>
  public uint? FormatId { get ; set; }
  
  /// <summary>
  /// Filter By Cell Color
  /// </summary>
  public bool? CellColor { get ; set; }
  
}
