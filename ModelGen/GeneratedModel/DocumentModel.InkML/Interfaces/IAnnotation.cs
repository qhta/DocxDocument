namespace DocumentModel.InkML;

/// <summary>
/// Defines the Annotation Class.
/// </summary>
public interface IAnnotation // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// type
  /// </summary>
  public string? Type { get ; set; }
  
  /// <summary>
  /// encoding
  /// </summary>
  public string? Encoding { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
