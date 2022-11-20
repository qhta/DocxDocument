namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Total Number of Characters.
/// </summary>
public interface ICharacters // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
