namespace DocumentModel.Presentation;

/// <summary>
/// View Scale.
/// </summary>
public interface IScaleFactor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Horizontal Ratio.
  /// </summary>
  public DocumentModel.Drawing.IRatioType? ScaleX { get ; set; }
  
  /// <summary>
  /// Vertical Ratio.
  /// </summary>
  public DocumentModel.Drawing.IRatioType? ScaleY { get ; set; }
  
}
