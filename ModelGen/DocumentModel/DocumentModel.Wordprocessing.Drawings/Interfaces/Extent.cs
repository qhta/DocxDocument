namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Inline Drawing Object Extents.
/// </summary>
public interface Extent // : System.Boolean
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public Int64? Cx { get ; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public Int64? Cy { get ; set; }
  
}
