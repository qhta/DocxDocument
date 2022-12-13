namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public interface BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Wordprocessing.BorderKind? Val { get ; set; }
  
  /// <summary>
  /// Border Color
  /// </summary>
  public String? Color { get ; set; }
  
  /// <summary>
  /// Border Theme Color
  /// </summary>
  public DocumentModel.Wordprocessing.ThemeColorKind? ThemeColor { get ; set; }
  
  /// <summary>
  /// Border Theme Color Tint
  /// </summary>
  public String? ThemeTint { get ; set; }
  
  /// <summary>
  /// Border Theme Color Shade
  /// </summary>
  public String? ThemeShade { get ; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public UInt32? Size { get ; set; }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  public UInt32? Space { get ; set; }
  
  /// <summary>
  /// Border Shadow
  /// </summary>
  public Boolean? Shadow { get ; set; }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  public Boolean? Frame { get ; set; }
  
}
