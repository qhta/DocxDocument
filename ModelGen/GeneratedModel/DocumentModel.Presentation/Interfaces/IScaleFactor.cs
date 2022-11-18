namespace DocumentModel.Presentation;

/// <summary>
/// View Scale.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IScaleX))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IScaleY))]
public interface IScaleFactor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
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
