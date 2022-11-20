namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocContentControlUpdateXsdString Class.
/// </summary>
public class EventDocContentControlUpdateXsdString: IEventDocContentControlUpdateXsdString
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
