namespace DocumentModel.Presentation;

/// <summary>
/// View Scale.
/// </summary>
public interface IScaleFactor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Horizontal Ratio.
  /// </summary>
  public IScaleX? ScaleX { get ; set; }
  
  /// <summary>
  /// Vertical Ratio.
  /// </summary>
  public IScaleY? ScaleY { get ; set; }
  
}
