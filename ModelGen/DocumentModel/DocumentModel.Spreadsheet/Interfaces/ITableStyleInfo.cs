namespace DocumentModel.Spreadsheet;

/// <summary>
/// Table Style.
/// </summary>
public interface ITableStyleInfo // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Style Name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// Show First Column
  /// </summary>
  public System.Boolean? ShowFirstColumn { get ; set; }
  
  /// <summary>
  /// Show Last Column
  /// </summary>
  public System.Boolean? ShowLastColumn { get ; set; }
  
  /// <summary>
  /// Show Row Stripes
  /// </summary>
  public System.Boolean? ShowRowStripes { get ; set; }
  
  /// <summary>
  /// Show Column Stripes
  /// </summary>
  public System.Boolean? ShowColumnStripes { get ; set; }
  
}
