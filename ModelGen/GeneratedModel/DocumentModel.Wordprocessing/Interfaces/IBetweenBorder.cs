namespace DocumentModel.Wordprocessing;

/// <summary>
/// Paragraph Border Between Identical Paragraphs.
/// </summary>
public interface IBetweenBorder // : DocumentFormat.OpenXml.Wordprocessing.BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public DocumentModel.Wordprocessing.Border? Val { get ; set; }
  
  /// <summary>
  /// Border Color
  /// </summary>
  public string? Color { get ; set; }
  
  /// <summary>
  /// Border Theme Color
  /// </summary>
  public ThemeColor? ThemeColor { get ; set; }
  
  /// <summary>
  /// Border Theme Color Tint
  /// </summary>
  public string? ThemeTint { get ; set; }
  
  /// <summary>
  /// Border Theme Color Shade
  /// </summary>
  public string? ThemeShade { get ; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public uint? Size { get ; set; }
  
  /// <summary>
  /// Border Spacing Measurement
  /// </summary>
  public uint? Space { get ; set; }
  
  /// <summary>
  /// Border Shadow
  /// </summary>
  public bool? Shadow { get ; set; }
  
  /// <summary>
  /// Create Frame Effect
  /// </summary>
  public bool? Frame { get ; set; }
  
}
