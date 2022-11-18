namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Dimension.
/// </summary>
public interface IDimension // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Measure
  /// </summary>
  public bool? Measure { get ; set; }
  
  /// <summary>
  /// Dimension Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Dimension Unique Name
  /// </summary>
  public string? UniqueName { get ; set; }
  
  /// <summary>
  /// Dimension Display Name
  /// </summary>
  public string? Caption { get ; set; }
  
}
