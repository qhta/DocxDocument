namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocSyncXsdString Class.
/// </summary>
public class EventDocSyncXsdString: IEventDocSyncXsdString
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
