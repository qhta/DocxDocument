namespace DocumentModel.Bibliography;

/// <summary>
/// Broadcaster.
/// </summary>
public interface IBroadcaster // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
