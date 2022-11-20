namespace DocumentModel.VariantTypes;

/// <summary>
/// Binary Blob.
/// </summary>
public interface IVTBlob // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
