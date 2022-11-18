namespace DocumentModel.ExtendedProperties;

/// <summary>
/// Name of Document Template.
/// </summary>
public interface ITemplate // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
