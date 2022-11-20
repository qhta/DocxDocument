namespace DocumentModel.VariantTypes;

/// <summary>
/// Binary Stream Object.
/// </summary>
public interface IVTOStreamData // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
