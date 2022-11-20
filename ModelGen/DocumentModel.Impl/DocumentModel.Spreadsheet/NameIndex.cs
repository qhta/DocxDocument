namespace DocumentModel.Spreadsheet;

/// <summary>
/// Member Unique Name Index.
/// </summary>
public class NameIndex: INameIndex
{
  /// <summary>
  /// Index Value
  /// </summary>
  public uint? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// String is a Set
  /// </summary>
  public bool? IsASet
  {
    get;
    set;
  }
  
}
