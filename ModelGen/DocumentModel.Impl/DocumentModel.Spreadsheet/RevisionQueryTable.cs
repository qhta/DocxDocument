namespace DocumentModel.Spreadsheet;

/// <summary>
/// Revision Query Table.
/// </summary>
public class RevisionQueryTable: IRevisionQueryTable
{
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// QueryTable Reference
  /// </summary>
  public string? Reference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Field Id
  /// </summary>
  public uint? FieldId
  {
    get;
    set;
  }
  
}
