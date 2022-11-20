namespace DocumentModel.VariantTypes;

/// <summary>
/// Binary Blob Object.
/// </summary>
public interface IVTOBlob // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
