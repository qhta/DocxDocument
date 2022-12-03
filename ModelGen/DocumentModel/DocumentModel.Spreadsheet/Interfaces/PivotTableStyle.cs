namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableStyle Class.
/// </summary>
public interface PivotTableStyle // : System.Boolean
{
  /// <summary>
  /// Table Style Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Show Row Header Formatting
  /// </summary>
  public Boolean? ShowRowHeaders { get ; set; }
  
  /// <summary>
  /// Show Table Style Column Header Formatting
  /// </summary>
  public Boolean? ShowColumnHeaders { get ; set; }
  
  /// <summary>
  /// Show Row Stripes
  /// </summary>
  public Boolean? ShowRowStripes { get ; set; }
  
  /// <summary>
  /// Show Column Stripes
  /// </summary>
  public Boolean? ShowColumnStripes { get ; set; }
  
  /// <summary>
  /// Show Last Column
  /// </summary>
  public Boolean? ShowLastColumn { get ; set; }
  
}
