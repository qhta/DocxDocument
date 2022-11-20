namespace DocumentModel.Office.Word;

/// <summary>
/// Defines the EventDocBuildingBlockAfterInsertXsdString Class.
/// </summary>
public class EventDocBuildingBlockAfterInsertXsdString: IEventDocBuildingBlockAfterInsertXsdString
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
