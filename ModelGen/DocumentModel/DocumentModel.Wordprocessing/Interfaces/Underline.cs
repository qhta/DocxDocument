namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Underline Class.
/// </summary>
public interface Underline
{
  /// <summary>
  /// Underline Style
  /// </summary>
  public UnderlineKind? Val { get ; set; }
  
  /// <summary>
  /// Underline Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor { get ; set; }
  
}
