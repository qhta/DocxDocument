namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Style.
/// </summary>
public interface ITableStyleElement // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Table Style Type
  /// </summary>
  public TableStyleValues? Type { get ; set; }
  
  /// <summary>
  /// Band Size
  /// </summary>
  public uint? Size { get ; set; }
  
  /// <summary>
  /// Formatting Id
  /// </summary>
  public uint? FormatId { get ; set; }
  
}
