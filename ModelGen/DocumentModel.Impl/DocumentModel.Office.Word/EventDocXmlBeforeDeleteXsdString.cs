namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocXmlBeforeDeleteXsdString Class.
/// </summary>
public class EventDocXmlBeforeDeleteXsdString: IEventDocXmlBeforeDeleteXsdString
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
