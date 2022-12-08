namespace DocumentModel.Drawings;

/// <summary>
/// Defines the PositiveSize2DType Class.
/// </summary>
public interface PositiveSize2DType
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
