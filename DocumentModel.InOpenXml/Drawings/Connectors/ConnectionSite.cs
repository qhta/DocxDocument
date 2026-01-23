namespace DocumentModel.Drawings;

/// <summary>
/// Represents a shape connection site, defining the angle and position where a connector attaches to a shape.
/// </summary>
public class ConnectionSite: ModelElement<DXD.ConnectionSite>
{
  /// <summary>
  /// Angle of the connection site.
  /// </summary>
  public string? Angle { get; set; }

  /// <summary>
  /// Position of the connection site as a two-dimensional adjustment point.
  /// </summary>
  public AdjustPoint2DType? Position { get; set; }
}