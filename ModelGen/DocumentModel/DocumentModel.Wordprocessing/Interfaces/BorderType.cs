namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public interface BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public BorderKind? Val { get ; set; }
  
  /// <summary>
  /// Border Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor { get ; set; }
  
}
