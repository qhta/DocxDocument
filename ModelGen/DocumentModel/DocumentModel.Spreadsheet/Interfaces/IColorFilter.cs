namespace DocumentModel.Spreadsheet;

/// <summary>
/// Color Filter Criteria.
/// </summary>
public interface IColorFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Differential Format Record Id
  /// </summary>
  public UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Filter By Cell Color
  /// </summary>
  public Boolean? CellColor { get ; set; }
  
}
