namespace DocumentModel.Office.LongProperties;

/// <summary>
/// Defines the LongProperty Class.
/// </summary>
public class LongProperty: ILongProperty
{
  /// <summary>
  /// name
  /// </summary>
  public string? Name
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
