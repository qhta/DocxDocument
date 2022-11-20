namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocContentControlBeforeDeleteXsdString Class.
/// </summary>
public class EventDocContentControlBeforeDeleteXsdString: IEventDocContentControlBeforeDeleteXsdString
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
