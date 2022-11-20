namespace DocumentModel.Spreadsheet;

/// <summary>
/// Icon Filter.
/// </summary>
public class IconFilter: IIconFilter
{
  /// <summary>
  /// Icon Set
  /// </summary>
  public IconSetValues? IconSet
  {
    get;
    set;
  }
  
  /// <summary>
  /// Icon Id
  /// </summary>
  public uint? IconId
  {
    get;
    set;
  }
  
}
