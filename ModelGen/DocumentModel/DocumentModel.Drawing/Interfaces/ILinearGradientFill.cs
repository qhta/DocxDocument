namespace DocumentModel.Drawing;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public interface ILinearGradientFill // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Angle
  /// </summary>
  public Int32? Angle { get ; set; }
  
  /// <summary>
  /// Scaled
  /// </summary>
  public Boolean? Scaled { get ; set; }
  
}
