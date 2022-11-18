namespace DocumentModel.Math;

/// <summary>
/// Phantom Properties.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IControlProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IShowPhantom))]
[ChildElementInfo(typeof(DocumentModel.Math.IZeroWidth))]
[ChildElementInfo(typeof(DocumentModel.Math.IZeroAscent))]
[ChildElementInfo(typeof(DocumentModel.Math.IZeroDescent))]
[ChildElementInfo(typeof(DocumentModel.Math.ITransparent))]
public interface IPhantomProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Phantom Show.
  /// </summary>
  public IShowPhantom? ShowPhantom { get ; set; }
  
  /// <summary>
  /// Phantom Zero Width.
  /// </summary>
  public IZeroWidth? ZeroWidth { get ; set; }
  
  /// <summary>
  /// Phantom Zero Ascent.
  /// </summary>
  public IZeroAscent? ZeroAscent { get ; set; }
  
  /// <summary>
  /// Phantom Zero Descent.
  /// </summary>
  public IZeroDescent? ZeroDescent { get ; set; }
  
  /// <summary>
  /// Transparent (Phantom).
  /// </summary>
  public ITransparent? Transparent { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.IControlProperties? ControlProperties { get ; set; }
  
}
