namespace DocumentModel.Drawings;

/// <summary>
/// Shape Extent.
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
