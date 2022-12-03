namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Style.
/// </summary>
public interface TableStyleInfo // : System.Boolean
{
  /// <summary>
  /// Style Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Show First Column
  /// </summary>
  public Boolean? ShowFirstColumn { get ; set; }
  
  /// <summary>
  /// Show Last Column
  /// </summary>
  public Boolean? ShowLastColumn { get ; set; }
  
  /// <summary>
  /// Show Row Stripes
  /// </summary>
  public Boolean? ShowRowStripes { get ; set; }
  
  /// <summary>
  /// Show Column Stripes
  /// </summary>
  public Boolean? ShowColumnStripes { get ; set; }
  
}
