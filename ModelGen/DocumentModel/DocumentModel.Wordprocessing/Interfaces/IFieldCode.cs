namespace DocumentModel.Wordprocessing;

/// <summary>
/// Field Code.
/// </summary>
public interface IFieldCode // : DocumentFormat.OpenXml.Wordprocessing.TextType
{
  /// <summary>
  /// space
  /// </summary>
  public SpaceProcessingModeValues? Space { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
