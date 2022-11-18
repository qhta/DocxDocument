namespace DocumentModel.VariantTypes;

/// <summary>
/// Binary Storage Object.
/// </summary>
public interface IVTOStorage // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
