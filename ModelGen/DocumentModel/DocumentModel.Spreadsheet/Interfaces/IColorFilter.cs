namespace DocumentModel.Spreadsheet;

/// <summary>
/// Color Filter Criteria.
/// </summary>
public interface IColorFilter // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Differential Format Record Id
  /// </summary>
  public System.UInt32? FormatId { get ; set; }
  
  /// <summary>
  /// Filter By Cell Color
  /// </summary>
  public System.Boolean? CellColor { get ; set; }
  
}
