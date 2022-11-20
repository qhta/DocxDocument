namespace DocumentModel.Wordprocessing;

/// <summary>
/// Unique Value for Record.
/// </summary>
public class UniqueTag: IUniqueTag
{
  /// <summary>
  /// val
  /// </summary>
  public IBase64BinaryValue? Val
  {
    get;
    set;
  }
  
}
