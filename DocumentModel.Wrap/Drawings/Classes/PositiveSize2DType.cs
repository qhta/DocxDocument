namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PositiveSize2DType Class.
/// </summary>
public class PositiveSize2DType: ModelElement
{
  /// <summary>
  ///   Extent Length
  /// </summary>
  public Int64? Cx { get; set; }

  /// <summary>
  ///   Extent Width
  /// </summary>
  public Int64? Cy { get; set; }
}