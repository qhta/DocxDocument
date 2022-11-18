namespace DocumentModel.VariantTypes;

/// <summary>
/// Binary Stream.
/// </summary>
public interface IVTStreamData // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
