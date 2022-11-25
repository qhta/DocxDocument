namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableStyle Class.
/// </summary>
public interface IPivotTableStyle // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Table Style Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Show Row Header Formatting
  /// </summary>
  public System.Boolean? ShowRowHeaders { get ; set; }
  
  /// <summary>
  /// Show Table Style Column Header Formatting
  /// </summary>
  public System.Boolean? ShowColumnHeaders { get ; set; }
  
  /// <summary>
  /// Show Row Stripes
  /// </summary>
  public System.Boolean? ShowRowStripes { get ; set; }
  
  /// <summary>
  /// Show Column Stripes
  /// </summary>
  public System.Boolean? ShowColumnStripes { get ; set; }
  
  /// <summary>
  /// Show Last Column
  /// </summary>
  public System.Boolean? ShowLastColumn { get ; set; }
  
}
