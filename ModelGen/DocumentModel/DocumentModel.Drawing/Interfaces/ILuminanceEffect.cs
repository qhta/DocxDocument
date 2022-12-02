namespace DocumentModel.Drawing;

/// <summary>
/// Luminance.
/// </summary>
public interface ILuminanceEffect // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Brightness
  /// </summary>
  public Int32? Brightness { get ; set; }
  
  /// <summary>
  /// Contrast
  /// </summary>
  public Int32? Contrast { get ; set; }
  
}
