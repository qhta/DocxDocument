namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocCloseXsdString Class.
/// </summary>
public class EventDocCloseXsdString: IEventDocCloseXsdString
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
