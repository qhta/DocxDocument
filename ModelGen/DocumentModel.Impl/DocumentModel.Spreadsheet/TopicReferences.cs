namespace DocumentModel.Spreadsheet;

/// <summary>
/// References.
/// </summary>
public class TopicReferences: ITopicReferences
{
  /// <summary>
  /// Reference
  /// </summary>
  public string? CellReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// Sheet Id
  /// </summary>
  public uint? SheetId
  {
    get;
    set;
  }
  
}
