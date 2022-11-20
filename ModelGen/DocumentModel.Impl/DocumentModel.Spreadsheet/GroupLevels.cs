namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the GroupLevels Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Spreadsheet.IGroupLevel))]
public class GroupLevels: IGroupLevels
{
  /// <summary>
  /// Grouping Level Count
  /// </summary>
  public uint? Count
  {
    get;
    set;
  }
  
}
