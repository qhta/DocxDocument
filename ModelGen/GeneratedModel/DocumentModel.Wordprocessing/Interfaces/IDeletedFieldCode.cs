namespace DocumentModel.Wordprocessing;

/// <summary>
/// Deleted Field Code.
/// </summary>
public interface IDeletedFieldCode // : DocumentFormat.OpenXml.Wordprocessing.TextType
{
  /// <summary>
  /// space
  /// </summary>
  public SpaceProcessingMode? Space { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
