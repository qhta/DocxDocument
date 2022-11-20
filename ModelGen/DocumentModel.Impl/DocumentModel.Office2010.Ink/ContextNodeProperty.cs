namespace DocumentModel.Office2010.Ink;

/// <summary>
/// Defines the ContextNodeProperty Class.
/// </summary>
public class ContextNodeProperty: IContextNodeProperty
{
  /// <summary>
  /// type
  /// </summary>
  public string? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
