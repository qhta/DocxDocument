namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocXmlAfterInsertXsdString Class.
/// </summary>
public class EventDocXmlAfterInsertXsdString: IEventDocXmlAfterInsertXsdString
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
