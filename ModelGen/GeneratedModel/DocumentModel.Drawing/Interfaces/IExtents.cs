namespace DocumentModel.Drawing;

/// <summary>
/// Extents.
/// </summary>
public interface IExtents // : DocumentFormat.OpenXml.Drawing.PositiveSize2DType
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
