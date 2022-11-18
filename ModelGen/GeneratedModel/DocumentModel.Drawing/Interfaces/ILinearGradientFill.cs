namespace DocumentModel.Drawing;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public interface ILinearGradientFill // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Angle
  /// </summary>
  public int? Angle { get ; set; }
  
  /// <summary>
  /// Scaled
  /// </summary>
  public bool? Scaled { get ; set; }
  
}
