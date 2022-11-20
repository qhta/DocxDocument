namespace DocumentModel.Wordprocessing;

/// <summary>
/// Deleted Text.
/// </summary>
public class DeletedText: IDeletedText
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
