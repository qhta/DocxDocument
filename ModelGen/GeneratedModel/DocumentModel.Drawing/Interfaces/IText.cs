namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Text Class.
/// </summary>
public interface IText // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
