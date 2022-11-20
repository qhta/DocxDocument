namespace DocumentModel.Spreadsheet;

/// <summary>
/// Range Set.
/// </summary>
public class RangeSet: IRangeSet
{
  /// <summary>
  /// Field Item Index Page 1
  /// </summary>
  public uint? FieldItemIndexPage1
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Item Index Page 2
  /// </summary>
  public uint? FieldItemIndexPage2
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Item index Page 3
  /// </summary>
  public uint? FieldItemIndexPage3
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Item Index Page 4
  /// </summary>
  public uint? FieldItemIndexPage4
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reference
  /// </summary>
  public string? Reference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Named Range
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet Name
  /// </summary>
  public string? Sheet
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
  
}
