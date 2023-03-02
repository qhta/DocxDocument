namespace DocumentModel.Drawings;

/// <summary>
///   Draw Arc To.
/// </summary>
public record ArcTo
{
  /// <summary>
  ///   Shape Arc Width Radius
  /// </summary>
  public String? WidthRadius { get; set; }

  /// <summary>
  ///   Shape Arc Height Radius
  /// </summary>
  public String? HeightRadius { get; set; }

  /// <summary>
  ///   Shape Arc Start Angle
  /// </summary>
  public String? StartAngle { get; set; }

  /// <summary>
  ///   Shape Arc Swing Angle
  /// </summary>
  public String? SwingAngle { get; set; }
}