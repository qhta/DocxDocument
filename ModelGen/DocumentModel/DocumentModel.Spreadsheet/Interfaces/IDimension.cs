namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Dimension.
/// </summary>
public interface IDimension // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Measure
  /// </summary>
  public System.Boolean? Measure { get ; set; }
  
  /// <summary>
  /// Dimension Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Dimension Unique Name
  /// </summary>
  public System.String? UniqueName { get ; set; }
  
  /// <summary>
  /// Dimension Display Name
  /// </summary>
  public System.String? Caption { get ; set; }
  
}
