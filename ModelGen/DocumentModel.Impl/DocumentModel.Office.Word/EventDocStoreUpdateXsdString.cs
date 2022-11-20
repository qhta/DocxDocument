namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocStoreUpdateXsdString Class.
/// </summary>
public class EventDocStoreUpdateXsdString: IEventDocStoreUpdateXsdString
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
