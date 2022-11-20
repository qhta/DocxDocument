namespace DocumentModel.Spreadsheet;

/// <summary>
/// Hyperlink.
/// </summary>
public class Hyperlink: IHyperlink
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? Reference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Relationship Id
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Location
  /// </summary>
  public string? Location
  {
    get;
    set;
  }
  
  /// <summary>
  /// Tool Tip
  /// </summary>
  public string? Tooltip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Display String
  /// </summary>
  public string? Display
  {
    get;
    set;
  }
  
}
