namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the OlapProperties Class.
/// </summary>
public class OlapProperties: IOlapProperties
{
  /// <summary>
  /// Local Cube
  /// </summary>
  public bool? Local
  {
    get;
    set;
  }
  
  /// <summary>
  /// Local Cube Connection
  /// </summary>
  public string? LocalConnection
  {
    get;
    set;
  }
  
  /// <summary>
  /// Local Refresh
  /// </summary>
  public bool? LocalRefresh
  {
    get;
    set;
  }
  
  /// <summary>
  /// Send Locale to OLAP
  /// </summary>
  public bool? SendLocale
  {
    get;
    set;
  }
  
  /// <summary>
  /// Drill Through Count
  /// </summary>
  public uint? RowDrillCount
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLAP Fill Formatting
  /// </summary>
  public bool? ServerFill
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLAP Number Format
  /// </summary>
  public bool? ServerNumberFormat
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLAP Server Font
  /// </summary>
  public bool? ServerFont
  {
    get;
    set;
  }
  
  /// <summary>
  /// OLAP Font Formatting
  /// </summary>
  public bool? ServerFontColor
  {
    get;
    set;
  }
  
}
