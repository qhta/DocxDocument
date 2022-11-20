namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocNewXsdString Class.
/// </summary>
public class EventDocNewXsdString: IEventDocNewXsdString
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
