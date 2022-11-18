namespace DocumentModel.VariantTypes;

/// <summary>
/// Binary Storage.
/// </summary>
public interface IVTStorage // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
