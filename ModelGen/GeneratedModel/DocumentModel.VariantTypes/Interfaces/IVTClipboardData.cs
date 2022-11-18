namespace DocumentModel.VariantTypes;

/// <summary>
/// Clipboard Data.
/// </summary>
public interface IVTClipboardData // : DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement
{
  /// <summary>
  /// Format Attribute
  /// </summary>
  public int? Format { get ; set; }
  
  /// <summary>
  /// size
  /// </summary>
  public uint? Size { get ; set; }
  
  /// <summary>
  /// Gets or sets the text of the current element.
  /// </summary>
  public string? Text { get ; set; }
  
}
