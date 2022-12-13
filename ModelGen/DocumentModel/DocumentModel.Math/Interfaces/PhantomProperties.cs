namespace DocumentModel.Math;

/// <summary>
/// Phantom Properties.
/// </summary>
public interface PhantomProperties
{
  /// <summary>
  /// Phantom Show.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ShowPhantom { get ; set; }
  
  /// <summary>
  /// Phantom Zero Width.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ZeroWidth { get ; set; }
  
  /// <summary>
  /// Phantom Zero Ascent.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ZeroAscent { get ; set; }
  
  /// <summary>
  /// Phantom Zero Descent.
  /// </summary>
  public DocumentModel.Math.BooleanKind? ZeroDescent { get ; set; }
  
  /// <summary>
  /// Transparent (Phantom).
  /// </summary>
  public DocumentModel.Math.BooleanKind? Transparent { get ; set; }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties { get ; set; }
  
}
