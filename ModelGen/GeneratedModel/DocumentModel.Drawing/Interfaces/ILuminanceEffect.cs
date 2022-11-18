namespace DocumentModel.Drawing;

/// <summary>
/// Luminance.
/// </summary>
public interface ILuminanceEffect // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Brightness
  /// </summary>
  public int? Brightness { get ; set; }
  
  /// <summary>
  /// Contrast
  /// </summary>
  public int? Contrast { get ; set; }
  
}
