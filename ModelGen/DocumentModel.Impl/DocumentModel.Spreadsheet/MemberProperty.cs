namespace DocumentModel.Spreadsheet;

/// <summary>
/// OLAP Member Property.
/// </summary>
public class MemberProperty: IMemberProperty
{
  /// <summary>
  /// OLAP Member Property Unique Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Cell
  /// </summary>
  public bool? ShowCell
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Tooltip
  /// </summary>
  public bool? ShowTip
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show As Caption
  /// </summary>
  public bool? ShowAsCaption
  {
    get;
    set;
  }
  
  /// <summary>
  /// Name Length
  /// </summary>
  public uint? NameLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// Property Name Character Index
  /// </summary>
  public uint? PropertyNamePosition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Property Name Length
  /// </summary>
  public uint? PropertyNameLength
  {
    get;
    set;
  }
  
  /// <summary>
  /// Level Index
  /// </summary>
  public uint? Level
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Index
  /// </summary>
  public uint? Field
  {
    get;
    set;
  }
  
}
