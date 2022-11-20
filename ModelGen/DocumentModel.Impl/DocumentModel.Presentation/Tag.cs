namespace DocumentModel.Presentation;

/// <summary>
/// Programmable Extensibility Tag.
/// </summary>
public class Tag: ITag
{
  /// <summary>
  /// Name
  /// </summary>
  public string? Name
  {
    get;
    set;
  }
  
  /// <summary>
  /// Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
