namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public interface BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public BorderKind? Type { get ; set; }
  
  /// <summary>
  /// Border Width
  /// </summary>
  public Int32? Width { get ; set; }
  
  /// <summary>
  /// Border shadow
  /// </summary>
  public Boolean? Shadow { get ; set; }
  
}
