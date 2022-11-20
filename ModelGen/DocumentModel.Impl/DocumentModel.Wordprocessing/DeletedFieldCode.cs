namespace DocumentModel.Wordprocessing;

/// <summary>
/// Deleted Field Code.
/// </summary>
public class DeletedFieldCode: IDeletedFieldCode
{
  /// <summary>
  /// space
  /// </summary>
  public SpaceProcessingModeValues? Space
  {
    get;
    set;
  }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text
  {
    get;
    set;
  }
  
}
