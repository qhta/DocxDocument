namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public interface DocumentBackground
{
  /// <summary>
  /// themeColor
  /// </summary>
  public ThemeColorKind? ThemeColor { get ; set; }
  
  /// <summary>
  /// Background.
  /// </summary>
  public DocumentModel.Vml.Background? Background { get ; set; }
  
}
