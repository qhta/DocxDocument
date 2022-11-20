namespace DocumentModel.Wordprocessing;

/// <summary>
/// Entry Name.
/// </summary>
public class DocPartName: IDocPartName
{
  /// <summary>
  /// Name Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Built-In Entry
  /// </summary>
  public bool? Decorated
  {
    get;
    set;
  }
  
}
