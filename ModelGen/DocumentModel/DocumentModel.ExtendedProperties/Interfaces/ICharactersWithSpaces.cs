namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Number of Characters (With Spaces).
/// </summary>
public interface ICharactersWithSpaces // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
