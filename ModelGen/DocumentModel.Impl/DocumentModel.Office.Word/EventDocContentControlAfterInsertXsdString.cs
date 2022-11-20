namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocContentControlAfterInsertXsdString Class.
/// </summary>
public class EventDocContentControlAfterInsertXsdString: IEventDocContentControlAfterInsertXsdString
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
