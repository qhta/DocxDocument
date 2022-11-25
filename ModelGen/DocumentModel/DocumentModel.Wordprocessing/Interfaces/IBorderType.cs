namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public interface IBorderType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Wordprocessing.BorderKind? Val { get ; set; }
  
  /// <summary>
  /// Border Color
  /// </summary>
  public System.String? Color { get ; set; }
  
  /// <summary>
  /// Border Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor { get ; set; }
  
  /// <summary>
  /// Border Theme Color Tint
  /// </summary>
  public System.String? ThemeTint { get ; set; }
  
  /// <summary>
  /// Border Theme Color Shade
  /// </summary>
  public System.String? ThemeShade { get ; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public System.UInt32? Size { get ; set; }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  public System.UInt32? Space { get ; set; }
  
  /// <summary>
  /// Border Shadow
  /// </summary>
  public System.Boolean? Shadow { get ; set; }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  public System.Boolean? Frame { get ; set; }
  
}
