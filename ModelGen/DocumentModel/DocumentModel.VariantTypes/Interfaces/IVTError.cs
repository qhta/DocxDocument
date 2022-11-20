namespace DocumentModel.VariantTypes;

/// <summary>
/// Error Status Code.
/// </summary>
public interface IVTError // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
