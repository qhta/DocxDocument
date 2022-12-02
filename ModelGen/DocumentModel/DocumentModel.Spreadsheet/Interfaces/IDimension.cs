namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Dimension.
/// </summary>
public interface IDimension // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Measure
  /// </summary>
  public Boolean? Measure { get ; set; }
  
  /// <summary>
  /// Dimension Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Dimension Unique Name
  /// </summary>
  public String? UniqueName { get ; set; }
  
  /// <summary>
  /// Dimension Display Name
  /// </summary>
  public String? Caption { get ; set; }
  
}
