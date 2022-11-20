namespace DocumentModel.Wordprocessing;

/// <summary>
/// Text.
/// </summary>
public class Text: IText
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
