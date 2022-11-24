namespace DocumentModel.Math;

/// <summary>
/// Phantom Properties.
/// </summary>
public interface IPhantomProperties // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public IControlProperties? ControlProperties { get ; set; }
  
}
