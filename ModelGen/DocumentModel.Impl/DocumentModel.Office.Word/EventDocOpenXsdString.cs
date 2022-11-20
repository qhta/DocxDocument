namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocOpenXsdString Class.
/// </summary>
public class EventDocOpenXsdString: IEventDocOpenXsdString
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
