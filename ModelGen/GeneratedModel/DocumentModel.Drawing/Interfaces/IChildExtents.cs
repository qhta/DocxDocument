namespace DocumentModel.Drawing;

/// <summary>
/// Child Extents.
/// </summary>
public interface IChildExtents // : DocumentFormat.OpenXml.Drawing.PositiveSize2DType
{
  /// <summary>
  /// Extent Length
  /// </summary>
  public long? Cx { get ; set; }
  
  /// <summary>
  /// Extent Width
  /// </summary>
  public long? Cy { get ; set; }
  
}
