namespace DocumentModel.Spreadsheet;

/// <summary>
/// Member Property MDX Metadata.
/// </summary>
public class MdxMemberProp: IMdxMemberProp
{
  /// <summary>
  /// Member Unique Name Index
  /// </summary>
  public uint? NameIndex
  {
    get;
    set;
  }
  
  /// <summary>
  /// Property Name Index
  /// </summary>
  public uint? PropertyNameIndex
  {
    get;
    set;
  }
  
}
