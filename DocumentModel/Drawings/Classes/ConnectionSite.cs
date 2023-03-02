namespace DocumentModel.Drawings;

/// <summary>
///   Shape Connection Site.
/// </summary>
public record ConnectionSite
{
  /// <summary>
  ///   Connection Site Angle
  /// </summary>
  public String? Angle { get; set; }

  /// <summary>
  ///   Position.
  /// </summary>
  public AdjustPoint2DType? Position { get; set; }
}