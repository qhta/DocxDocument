namespace DocumentModel.Drawings;

/// <summary>
///   Shape Connection Site.
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