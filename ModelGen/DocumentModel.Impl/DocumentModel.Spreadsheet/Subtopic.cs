namespace DocumentModel.Spreadsheet;

/// <summary>
/// Strings in Subtopic.
/// </summary>
public class Subtopic: ISubtopic
{
  /// <summary>
  /// Content Contains Significant Whitespace
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
