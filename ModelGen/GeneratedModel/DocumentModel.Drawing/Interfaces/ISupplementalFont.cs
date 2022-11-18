namespace DocumentModel.Drawing;

/// <summary>
/// Font.
/// </summary>
public interface ISupplementalFont // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Script
  /// </summary>
  public string? Script { get ; set; }
  
  /// <summary>
  /// Typeface
  /// </summary>
  public string? Typeface { get ; set; }
  
}
