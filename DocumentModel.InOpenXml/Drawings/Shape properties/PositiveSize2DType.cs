namespace DocumentModel.Drawings;
/// <summary>
///   Represents a positive 2D size, defined by its length and width.
/// </summary>
public partial class PositiveSize2DType : ModelElement<DXD.PositiveSize2DType>
{
  /// <summary>
  ///   Length of the extent.
  /// </summary>
  public Int64? Cx { get; set; }
  /// <summary>
  ///   Width of the extent.
  /// </summary>
  public Int64? Cy { get; set; }
}