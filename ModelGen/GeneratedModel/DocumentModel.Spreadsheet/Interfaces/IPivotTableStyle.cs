namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the PivotTableStyle Class.
/// </summary>
public interface IPivotTableStyle // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Table Style Name
  /// </summary>
  public string? Name { get ; set; }
  
  /// <summary>
  /// Show Row Header Formatting
  /// </summary>
  public bool? ShowRowHeaders { get ; set; }
  
  /// <summary>
  /// Show Table Style Column Header Formatting
  /// </summary>
  public bool? ShowColumnHeaders { get ; set; }
  
  /// <summary>
  /// Show Row Stripes
  /// </summary>
  public bool? ShowRowStripes { get ; set; }
  
  /// <summary>
  /// Show Column Stripes
  /// </summary>
  public bool? ShowColumnStripes { get ; set; }
  
  /// <summary>
  /// Show Last Column
  /// </summary>
  public bool? ShowLastColumn { get ; set; }
  
}
