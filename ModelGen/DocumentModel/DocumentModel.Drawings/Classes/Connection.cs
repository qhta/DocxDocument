namespace DocumentModel.Drawings;

/// <summary>
/// Connection.
/// </summary>
public class Connection
{
  /// <summary>
  /// Point Type
  /// </summary>
  public ConnectionKind? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList3? ExtensionList
  {
    get;
    set;
  }
  
}
