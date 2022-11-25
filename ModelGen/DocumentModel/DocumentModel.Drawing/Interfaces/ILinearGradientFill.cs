namespace DocumentModel.Drawing;

/// <summary>
/// Linear Gradient Fill.
/// </summary>
public interface ILinearGradientFill // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Angle
  /// </summary>
  public System.Int32? Angle { get ; set; }
  
  /// <summary>
  /// Scaled
  /// </summary>
  public System.Boolean? Scaled { get ; set; }
  
}
