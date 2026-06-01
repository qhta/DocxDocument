namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IShape Connection Site.
/// </summary>
public class ConnectionSite: ModelElement
{
  /// <summary>
  ///   Connection Site Angle
  /// </summary>
  public string? Angle { get; set; }

  /// <summary>
  ///   Position.
  /// </summary>
  public AdjustPoint2DType? Position { get; set; }
}
